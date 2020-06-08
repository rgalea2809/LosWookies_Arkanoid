using System;
using System.Drawing;
using System.Windows.Forms;

namespace Wookies_arkanoid.Game
{
    public partial class Play : Form
    {
        private DesignPictureBox[,] dpb;
        private PictureBox ball;
        private Label score;
        private Label lives;
        private int countScore;
        
        public Play()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }

        private void Play_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("../../Img/Player.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox1.Top = (Height - pictureBox1.Height) - 80;
            pictureBox1.Left = (Width / 2) - (pictureBox1.Width / 2);
            
            pictureBox2.BackgroundImage = Image.FromFile("../../Img/Heart.png");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;

            countScore = 0;
            
            score = new Label();
            score.Size = new Size(180, 60);
            score.Location = new Point((Width - score.Width) - 50);
            score.Text = "Score: 0";
            score.TextAlign = ContentAlignment.MiddleCenter;
            score.Font = new System.Drawing.Font("Comic Sans MS", 22,FontStyle.Bold, 
                GraphicsUnit.Point, ((0)));
            score.ForeColor = Color.White;
            Controls.Add(score);
            score.BackColor = Color.Transparent;
            
            lives = new Label();
            lives.Size = new Size(99, 69);
            lives.Location = new Point(100, -9);
            lives.Text = "X3";
            lives.TextAlign = ContentAlignment.MiddleCenter;
            lives.Font = new Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, 
                GraphicsUnit.Point, ((0)));
            lives.ForeColor = Color.White;
            Controls.Add(lives);
            lives.BackColor = Color.Transparent;

            ball = new PictureBox();
            ball.Width = ball.Height = 40;
            ball.BackgroundImage = Image.FromFile("../../Img/pelota.png");
            ball.BackgroundImageLayout = ImageLayout.Stretch;
            ball.BackColor = Color.Transparent;

            ball.Top = pictureBox1.Top - ball.Height;
            ball.Left = pictureBox1.Left + (pictureBox1.Width / 2) - (ball.Width / 2);

            Controls.Add(ball);

            LoadBricks();

            timer1.Start();
        }
        
        private void LoadBricks()
        {
            int xAxis = 12;
            int yAxis = 6;

            int pbh = (int) ((Height * 0.3) / yAxis);
            int pbw = (Width - xAxis) / xAxis;
            

            dpb = new DesignPictureBox[yAxis, xAxis];
           

            for (int i = 0; i < yAxis; i++)
            {
                for (int j = 0; j < xAxis; j++)
                {
                    dpb[i, j] = new DesignPictureBox();

                    if (i == 0)
                        dpb[i, j].Golpes = 2;
                    else
                        dpb[i, j].Golpes = 1;

                    dpb[i, j].Height = pbh;
                    dpb[i, j].Width = pbw;

                    dpb[i, j].Left = j * pbw;
                    dpb[i, j].Top = i * pbh + 60;

                    dpb[i, j].BackgroundImage = Image.FromFile("../../Img/" + (i + 1) + ".png");
                    dpb[i, j].BackgroundImageLayout = ImageLayout.Stretch;

                    dpb[i, j].Tag = "blocks";
                   

                    Controls.Add(dpb[i, j]);
                    
                }
            }

        }

        private void Play_MouseMove(object sender, MouseEventArgs e)
        {
            if (!DataGame.startGame)
            {
                if (e.X < (Width - pictureBox1.Width))
                    pictureBox1.Left = e.X;
                ball.Left = pictureBox1.Left + (pictureBox1.Width / 2) - (ball.Width / 2);
            }
            else
            {
                if (e.X < (Width - pictureBox1.Width))
                    pictureBox1.Left = e.X;
            }
        }

        private void Play_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)

                DataGame.startGame = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!DataGame.startGame)
                return;
            ball.Left += DataGame.dirX;
            ball.Top += DataGame.dirY;

            bounceBall();
        }
        
        private void bounceBall()
        {
            score.Text = "Score :" + countScore;
            
            

            if (ball.Bottom > Height)
            {
                Application.Exit();
            }

            if (ball.Bottom < Top +105)
            {
                DataGame.dirY = -DataGame.dirY;
            }
               

            if (ball.Left < 0 || ball.Right > Width)
            {
                DataGame.dirX = -DataGame.dirX;
                return;
            }

            if (ball.Bounds.IntersectsWith(pictureBox1.Bounds))
                DataGame.dirY = -DataGame.dirY;
            
            
            
            for (int i = 5 ; i >= 0 ; i--)
            {
                for (int j = 0; j < 12; j++)
                {
                    
                    
                    if (ball.Bounds.IntersectsWith(dpb[i, j].Bounds))
                    {

                        dpb[i, j].Golpes--;

                        if (dpb[i, j].Golpes == 0)
                        {

                            Controls.Remove(dpb[i, j]);

                            DataGame.dirY = -DataGame.dirY;

                            countScore++;

                        }
                        
                    }

                  
                }
                
            }
        }
    }
}