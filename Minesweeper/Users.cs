using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data; //used for Microsoft Access DB

namespace Minesweeper
{
    public class Users
    {
        // Microsoft Access Connection
        const string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Minesweeper/ScoreBoardDB.accdb;";
        OleDbConnection myConnection = new OleDbConnection(strConnection);
        string UserName;
        double TimerValue;

        public Users(string UserName)
        {
            this.UserName = UserName;
            getScores();
        }

        //default constructor
        public Users()
        {
            this.UserName = "";
            this.TimerValue = 0.00;
        }

        public void getScores()
        {
            string selectScores = string.Format("SELECT * FROM Users WHERE Users='{0}'", UserName);
            DataSet dataset = new DataSet();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(selectScores, myConnection);
            dataAdapter.Fill(dataset);

            if (dataset.Tables[0].Rows.Count > 0)
            {
                DataRow row = dataset.Tables[0].Rows[0];
                this.UserName = Convert.ToString(row["UserName"]);
                this.TimerValue = Convert.ToInt16(row["TimerValue"]);
            }
            else 
            {
                newUser();
            }
        }

        public void UpdateScores()
        {
            string update = string.Format("UPDATE Users SET UserName='{0}', TimerValue='{1}'", UserName, TimerValue);
            OleDbCommand insertCommand = new OleDbCommand(update, myConnection);
            myConnection.Open();
            insertCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void newUser()
        {
            string insert = string.Format("INSERT INTO Users (UserName,) VALUES ('0')");
            OleDbCommand insertCommand = new OleDbCommand(insert, myConnection);
            myConnection.Open();
            insertCommand.ExecuteNonQuery();
            myConnection.Close();
            getScores();
        }

        public void setUser(string UserName, double TimerValue)
        {
            this.UserName = UserName;
            this.TimerValue = TimerValue;
            UpdateScores();
        }


        //Getters and Setters

        public void setUserName(string UserName)
        {
            this.UserName = UserName;
        }

        public string getUserName()
        {
            return UserName;
        }

        public void setTime(double TimerValue)
        {
            this.TimerValue = TimerValue;
        }

        public double getTime()
        {
            return TimerValue;
        }

    }
}



       // SortedList<string, double> Users = new SortedList<string, double()>;

        //try
        //{
	    //    myConnection.Open();
	      //  myDataReader = myCommand.ExecuteReader();
	
        //    while(myDataReader.Read())
        //    {
        //        string userName = myDataReader["UserName"].ToString();
        //        double timerValue = double.Parse(myDataReader["TimerValue"].ToString());
        //        Users.Add(userName, timerValue);
        //    }
        //}
        //catch (OleDbException ex)
        //{
        //    MessageBox.Show("Error: " & ex.Message); 
        //}

        //finally
        //{
        //    myConnection.Close();
        //}
