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
        private PictureTile[,] ptArr;
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
            this.Size = new System.Drawing.Size(450, 450);
            this.numMines = 10;
            ptArr = new PictureTile[9, 9];

            for(int i = 0; i < 9; i++){
                for (int j = 0; j < 9; j++ )
                {
                    ptArr[i, j] = new PictureTile(i, j);
                    ptArr[i, j].Location = new Point(j * 35 + 50, i * 32 + 50);
                    ptArr[i, j].BorderStyle = BorderStyle.FixedSingle;
                    ptArr[i, j].Visible = true;
                    ptArr[i, j].Width = 35;
                    ptArr[i, j].Height = 35;
                    ptArr[i, j].BringToFront();
                    ptArr[i, j].Image = Image.FromFile("../../Images/BoardTile_UnClicked.png");

                    ptArr[i, j].MouseClick += new MouseEventHandler((o, a) =>
                    {
                        PictureTile pt = ((PictureTile)o);
                        pt.Image = Image.FromFile("../../Images/EmptyTile.png");
                        
                        
                    });

                    this.Controls.Add(ptArr[i, j]);

                }
            }
            
        }

        public void makeMedium()
        {
            this.Size = new System.Drawing.Size(700, 700);
            this.numMines = 40;
            ptArr = new PictureTile[16, 16];

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {

                    ptArr[i, j] = new PictureTile(i, j);
                    ptArr[i, j].Location = new Point(j * 35 + 50, i * 32 + 50);
                    ptArr[i, j].BorderStyle = BorderStyle.FixedSingle;
                    ptArr[i, j].Visible = true;
                    ptArr[i, j].Width = 35;
                    ptArr[i, j].Height = 35;
                    ptArr[i, j].BringToFront();
                    ptArr[i, j].Image = Image.FromFile("../../Images/BoardTile_UnClicked.png");

                    ptArr[i, j].MouseClick += new MouseEventHandler((o, a) =>
                    {
                        PictureTile pt = ((PictureTile)o);
                        pt.Image = Image.FromFile("../../Images/EmptyTile.png");

                    });

                    this.Controls.Add(ptArr[i, j]);
                   
                }
            }
        }

        public void makeHard()
        {
            this.Size = new System.Drawing.Size(1150, 650);
            this.numMines = 99;
            ptArr = new PictureTile[16, 30];

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 30; j++)
                {

                    ptArr[i, j] = new PictureTile(i, j);
                    ptArr[i, j].Location = new Point(j * 35 + 50, i * 32 + 50);
                    ptArr[i, j].BorderStyle = BorderStyle.FixedSingle;
                    ptArr[i, j].Visible = true;
                    ptArr[i, j].Width = 35;
                    ptArr[i, j].Height = 35;
                    ptArr[i, j].BringToFront();
                    ptArr[i, j].Image = Image.FromFile("../../Images/BoardTile_UnClicked.png");

                    ptArr[i, j].MouseClick += new MouseEventHandler((o, a) =>
                    {
                        PictureTile pt = ((PictureTile)o);
                        pt.Image = Image.FromFile("../../Images/EmptyTile.png");

                    });

                    this.Controls.Add(ptArr[i, j]);

                }
            }
        }

        public class PictureTile : PictureBox
        {
            public int x, y;

            public PictureTile(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }

}
