using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork;


namespace CourseWork
{
    public partial class GameForm : Form
    {
        public int GaugeWidth = 45;
        public int GaugeHeight = 45;

        public int Columns;
        public int Rows;
        public int GreenButtons = 0;

        public int GameFieldStartX = 25;
        public int GameFieldStartY = 80;

        public bool[,] GaugeStates;

        public bool GameActive = false;

        public Image redButtonTexture = Bitmap.FromFile("GaugeRed.png");
        public Image greenButtonTexture = Bitmap.FromFile("GaugeGreen.png");

        public Graphics GFX;
        public GameForm()
        {
            InitializeComponent();
            GFX = this.CreateGraphics();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            if (columnsBox.Text != "" && rowsBox.Text != "")
            {
                Columns = Int32.Parse(columnsBox.Text);
                Rows = Int32.Parse(rowsBox.Text);
                GaugeStates = new bool[Columns,Rows];
                if (Columns * GaugeWidth + 75 < 700)
                    Program.gameForm.Size = new System.Drawing.Size(700, Rows * GaugeHeight + 130);
                else
                    Program.gameForm.Size = new System.Drawing.Size(Columns * GaugeWidth + 75, Rows * GaugeHeight + 130);

                GFX.Clear(Color.White);
                if (textureBox.Text == "Обычный")
                {
                    redButtonTexture = Bitmap.FromFile("GaugeRed.png");
                    greenButtonTexture = Bitmap.FromFile("GaugeGreen.png");
                }
                else if (textureBox.Text == "Красивый")
                {
                    redButtonTexture = Bitmap.FromFile("ButtonRed.png");
                    greenButtonTexture = Bitmap.FromFile("ButtonGreen.png");
                }
                else if (textureBox.Text == "Упрощенный")
                {
                    redButtonTexture = Bitmap.FromFile("MarkRed.png");
                    greenButtonTexture = Bitmap.FromFile("MarkGreen.png");
                }
                for (int i = 0; i < Columns; i++)
                {
                    for (int j = 0; j < Rows; j++)
                    {
                        GFX.DrawImage(redButtonTexture, new Point(GameFieldStartX + GaugeWidth * i, GameFieldStartY + GaugeHeight * j));
                        GaugeStates[i,j] = false;
                    }
                }
                GameActive = true;
            }
        }

        private void GameForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (GameActive)
            {
                if (e.X > GameFieldStartX && e.X <= GameFieldStartX + Columns * GaugeWidth && e.Y > GameFieldStartY && e.Y <= GameFieldStartY + Rows * GaugeHeight)
                {
                    for (int i = 0; i < Columns; i++)
                    {
                        for (int j = 0; j < Rows; j++)
                        {
                            if (e.X > GameFieldStartX + GaugeWidth * i && e.X <= GameFieldStartX + GaugeWidth * (i + 1))
                            {
                                if (GaugeStates[i, j])
                                    GaugeStates[i, j] = false;
                                else
                                    GaugeStates[i, j] = true;
                            }
                            else if (e.Y > GameFieldStartY + GaugeHeight * j && e.Y <= GameFieldStartY + GaugeHeight * (j + 1))
                            {
                                if (GaugeStates[i, j])
                                    GaugeStates[i, j] = false;
                                else
                                    GaugeStates[i, j] = true;
                            }
                            if (GaugeStates[i, j])
                                GFX.DrawImage(greenButtonTexture, new Point(GameFieldStartX + GaugeWidth * i, GameFieldStartY + GaugeHeight * j));
                            else
                                GFX.DrawImage(redButtonTexture, new Point(GameFieldStartX + GaugeWidth * i, GameFieldStartY + GaugeHeight * j));
                        }
                    }
                    for (int i = 0; i < Columns; i++)
                    {
                        for (int j = 0; j < Rows; j++)
                        {
                            if (GaugeStates[i, j])
                                GreenButtons++;
                            else
                            {
                                GreenButtons = 0;
                                break;
                            }  
                        }
                    }
                    if (GreenButtons == Columns * Rows)
                    {
                        GFX.Clear(Color.White);
                        Program.gameForm.Size = new System.Drawing.Size(900, 700);
                        GFX.DrawImage(Bitmap.FromFile("Win.png"), new Point(GameFieldStartX, GameFieldStartY));
                        GameActive = false;
                    }
                }
            }
        }
    }
}
