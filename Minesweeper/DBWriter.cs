using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Minesweeper
{
    public class DBWriter
    {

        // Microsoft Access Connection
        const string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Minesweeper/ScoreBoardDB.accdb;";
        string sqlUserName;
        ScoreBoardDBDataSet objDataSet = new ScoreBoardDBDataSet("Users");
        OleDbDataAdapter objAdapter;

        OleDbConnection myConnection = new OleDbConnection(strConnection);
        OleDbCommand insertUserNameCommand;

        public void setUserName(string UserName)
        {
            
            sqlUserName = "INSERT INTO Users (UserName)" + "VALUES ('" + UserName + "')";
            insertUserNameCommand = new OleDbCommand(sqlUserName, myConnection);

            try
            {
                myConnection.Open();
                insertUserNameCommand.ExecuteNonQuery();
            }

            catch (OleDbException ex)
            { }

            catch (SystemException ex)
            { }

            finally
            {
                myConnection.Close();
            }

        }


        // SortedList<string, double> Users = new SortedList<string, double()>;



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


    }
}