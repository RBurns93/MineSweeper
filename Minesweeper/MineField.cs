using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{


    public partial class MineField : Form
    {
        private InitializationForm initForm;
        public int mode;
        private PictureBox[,] pbArr;
        private int numMines;
        private SweeperGame sg;

        public MineField()
        {
            InitializeComponent();
        }


        //mode is used to tell the minefield how to draw itself (easy, medium, or hard)
        public MineField(InitializationForm init, int mode)
        {
            this.initForm = init;
            InitializeComponent();
            this.mode = mode;

            switch(mode){
                case 1:
                    makeEasy();
                    break;
                case 2:
                    makeMedium();
                    break;
                case 3:
                    makeHard();
                    break;
            }


        }

        private void MineField_Closed(object sender, FormClosedEventArgs e)
        {
            initForm.Show();
        }

        public void makeEasy()
        {
            this.Size = new System.Drawing.Size(300, 300);
            this.numMines = 10;
            pbArr = new PictureBox[9, 9];

            for(int i = 0; i < 9; i++){
                for (int j = 0; j < 9; j++ )
                {
                    pbArr[i, j] = new PictureBox();
                    pbArr[i, j].Location = new Point(j * 32 + 50, i * 32 + 50);
                    pbArr[i, j].BorderStyle = BorderStyle.Fixed3D;
                    pbArr[i, j].Visible = true;
                    pbArr[i, j].Width = 32;
                    pbArr[i, j].Height = 32;
                    pbArr[i, j].BringToFront();

                    pbArr[i, j].MouseClick += new MouseEventHandler((o, a) =>
                    {
                        PictureBox pb = ((PictureBox)o);
                        
                    });

                    this.Controls.Add(pbArr[i, j]);

                }
            }
            
        }

        public void makeMedium()
        {
            this.Size = new System.Drawing.Size(450, 450);
            this.numMines = 40;
            pbArr = new PictureBox[16, 16];

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {

                    pbArr[i, j] = new PictureBox();
                    pbArr[i, j].Location = new Point(j * 32 + 55, i * 32 + 60);
                    pbArr[i, j].BorderStyle = BorderStyle.Fixed3D;
                    pbArr[i, j].Visible = true;
                    pbArr[i, j].Width = 32;
                    pbArr[i, j].Height = 32;
                    pbArr[i, j].BringToFront();
                    this.Controls.Add(pbArr[i, j]);

                    pbArr[i, j].MouseClick += new MouseEventHandler((o, a) =>
                    {



                    });

                }
            }
        }

        public void makeHard()
        {
            this.Size = new System.Drawing.Size(715, 450);
            this.numMines = 99;
            pbArr = new PictureBox[16, 30];

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 30; j++)
                {

                    pbArr[i, j] = new PictureBox();
                    pbArr[i, j].Location = new Point(j * 32 + 50, i * 32 + 70);
                    pbArr[i, j].BorderStyle = BorderStyle.Fixed3D;
                    pbArr[i, j].Visible = true;
                    pbArr[i, j].Width = 20;
                    pbArr[i, j].Height = 20;
                    pbArr[i, j].BringToFront();

                    pbArr[i, j].MouseClick += new MouseEventHandler((o, a) => {
                        


                    });

                    this.Controls.Add(pbArr[i, j]);

                }
            }
        }
    }

}
