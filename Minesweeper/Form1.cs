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
<<<<<<< HEAD
            users.setUserName(txtBName.Text);

=======
            
>>>>>>> 1d2ef488c6aa973c1bc1c53111e8f7c69260ff96
            this.Hide();
            int mode;

            if(radBtnEasy.Checked){
                mode = 1;
            }else if(radBtnMedium.Checked){
                mode = 2;
            }else{
                mode = 3;
            }

            MineField mineField = new MineField(this, mode);
            mineField.Show();
            
        }
        

    }
}
