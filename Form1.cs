using Pie_Pie_Snake_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace Pie_Pie_Snake_Game
{
    public partial class Form1 : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private Circle Pie = new Circle();
        int maxWidth;
        int maxHeight;
        int score;
        int highScore;

        Random random = new Random();
        bool goLeft,goRight,goUp,goDown;


        public Form1()
        {
            InitializeComponent();
            new Setting();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Setting.Directions != "right") {

                goLeft = true;
            }

            if (e.KeyCode == Keys.Right && Setting.Directions != "left")
            {

                goRight  = true;
            }

            if (e.KeyCode == Keys.Up && Setting.Directions != "down")
            {

                goUp = true;
            }

            if (e.KeyCode == Keys.Down && Setting.Directions != "up")
            {

                goDown = true;
            }


        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {

                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {

                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {

                goDown = false;
            }
        }

        private void Start(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void TakeSnapShot(object sender, EventArgs e)
        {
            Label caption = new Label();
            caption.Text = "I scored: " + score + " and my Highscore is " + highScore + " in the Snake Game";
            caption.Font = new Font("Ariel", 12, FontStyle.Bold);
            caption.ForeColor = Color.Purple;
            caption.AutoSize = false;
            caption.Width = picCanvas.Width;
            caption.Height = 30;
            caption.TextAlign = ContentAlignment.MiddleCenter;
            picCanvas.Controls.Add(caption);
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Snake Game SnapShot";
            dialog.DefaultExt = "jpg";
            dialog.Filter = "JPG Image File | *.jpg";
            dialog.ValidateNames = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(picCanvas.Width);
                int height = Convert.ToInt32(picCanvas.Height);
                Bitmap bmp = new Bitmap(width, height);
                picCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                picCanvas.Controls.Remove(caption);
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            //setting the directions

            if (goLeft)
            {
                Setting.Directions = "left";
            }
            if (goRight)
            {
                Setting.Directions = "right";
            }
            if (goDown)
            {
                Setting.Directions = "down";
            }
            if (goUp)
            {
                Setting.Directions = "up";
            }
            // end of directions
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Setting.Directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }
                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }
                    if (Snake[i].X == Pie.X && Snake[i].Y == Pie.Y)
                    {
                        EatPie();
                    }
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            picCanvas.Invalidate();
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {

            Graphics canvas = e.Graphics;

            Brush snakeColor;

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {

                    snakeColor = Brushes.Black;

                }

                else {
                    snakeColor = Brushes.DarkGreen;

                }

                 canvas.FillEllipse(snakeColor, new Rectangle(Snake[i].X * Setting.Width,
                     Snake[i].Y * Setting.Height,
                    Setting.Width, Setting.Height));

            }


            canvas.FillEllipse(Brushes.DarkRed ,new Rectangle(Pie.X * Setting.Width,
                     Pie.Y * Setting.Height,
                    Setting.Width, Setting.Height));


        }


        private void RestartGame() {

            maxWidth = picCanvas.Width / Setting.Width - 1;
            maxHeight = picCanvas.Height / Setting.Height - 1;

            Snake.Clear();
            startButton.Enabled = false;
            snapButton.Enabled = false;
            score = 0;
            txtScore.Text = "Score: " + score;

            Circle Head = new Circle { X = 10 , Y = 5, };
            Snake.Add(Head); // addding head part of  snake 
            
            for (int i = 0; i < 10; i++)
            {
                Circle Body = new Circle();
                Snake.Add(Body);
            }

            Pie = new Circle { X = random.Next(2,maxWidth), Y = random.Next(2,maxHeight) };
            gameTimer.Start();

        }


        private void EatPie() {

            score += 1;
            txtScore.Text = "Score: " + score;
            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(body);
            Pie = new Circle { X = random.Next(2, maxWidth), Y = random.Next(2, maxHeight) };
        
    }


        private void GameOver() {

            gameTimer.Stop();
            startButton.Enabled = true;
            snapButton.Enabled = true;
            if (score > highScore)
            {
                highScore = score;
                txtHighScore.Text = "High Score: " + Environment.NewLine + highScore;
                txtHighScore.ForeColor = Color.Maroon;
                txtHighScore.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }

}
    

