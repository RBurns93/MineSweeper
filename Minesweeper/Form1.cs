using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;



namespace Minesweeper
{

    public partial class InitializationForm : Form
    {
        DBWriter writer = new DBWriter();
        Users users = new Users();

        //GIT COMMIT YOOOOOOOO

        public InitializationForm()
        {
            InitializeComponent();
            radBtnEasy.Checked = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            users.setUserName(txtBName.Text);

            this.Hide();
            MineField mineField = new MineField(this);
            mineField.Show();
            
        }
        

    }
}
