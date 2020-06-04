using System;
using System.Windows.Forms;

namespace Wookies_arkanoid.Vista
{
    public partial class PlayGame : Form
    {
        
        bool goLeft;
        bool goRight;
        bool isGameOver;

        int score;
        int ballx;
        int bally;
        int playerSpeed;
        
        
        public PlayGame()
        {
            InitializeComponent();
            setupGame();
        }
        
        private void setupGame()
        {

            score = 0;
            ballx = 5;
            bally = 5;
            playerSpeed = 12;

            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            ball.Left += ballx;
            ball.Top += bally;
            txtScore.Text = "Score: " + score;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }

            if (goRight == true && player.Left < 500)
            {

                player.Left += playerSpeed;
            }

            if (player.Left < 1)
            {
                goLeft = false;
            }

            else if (player.Left + player.Width > 655)
            {
                goRight = false;
            }


            if (ball.Left + ball.Width > ClientSize.Width || ball.Left < 0)
            {
                ballx = -ballx;
            }

            if (ball.Top < 0 || ball.Bounds.IntersectsWith(player.Bounds))
            {
                bally = -bally;

            }

            if (ball.Top + ball.Height > ClientSize.Height)
            {
                gameOver();
                MessageBox.Show("You Lose!");

            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string) x.Tag == "blocks")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {

                        if (x == pictureBox3 || x == pictureBox4 || x == pictureBox6 || x == pictureBox5 ||
                            x == pictureBox14 || x == pictureBox8)
                        {
                            this.Controls.Remove(x);

                            bally = -bally;

                            score += 10;
                        }

                        if (x == pictureBox9 || x == pictureBox10 || x == pictureBox11 || x == pictureBox12 ||
                            x == pictureBox13 || x == pictureBox15)
                        {
                            this.Controls.Remove(x);

                            bally = -bally;

                            score += 8;
                        }

                        if (x == pictureBox7 || x == pictureBox16 || x == pictureBox17 || x == pictureBox18 ||
                            x == pictureBox19 || x == pictureBox20)
                        {
                            this.Controls.Remove(x);

                            bally = -bally;

                            score += 6;
                        }

                        if (x == pictureBox21 || x == pictureBox22 || x == pictureBox23 || x == pictureBox24 ||
                            x == pictureBox25 || x == pictureBox26)
                        {
                            this.Controls.Remove(x);

                            bally = -bally;

                            score += 4;
                        }

                        if (x == pictureBox27 || x == pictureBox28 || x == pictureBox29 || x == pictureBox30 ||
                            x == pictureBox31 || x == pictureBox32)
                        {
                            this.Controls.Remove(x);

                            bally = -bally;

                            score += 2;
                        }

                        if (x == pictureBox33 || x == pictureBox34 || x == pictureBox35 || x == pictureBox36 ||
                            x == pictureBox37 || x == pictureBox38)
                        {
                            this.Controls.Remove(x);

                            bally = -bally;

                            score++;
                        }
                    }
                }

                if (score == 186)
                {
                    gameOver();
                    MessageBox.Show("You Win!");
                }

                if (ball.Top > 696)
                {
                    gameOver();
                    MessageBox.Show("You Lose!");
                }

            }
            
            
        }

        private void PlayGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
                
            }

            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                gameTimer.Start();
            }
        }

        private void PlayGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
                    
            if(e.KeyCode == Keys.Right)
            {
                goRight = false;
                        
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                gameTimer.Start();
            }
        }
        
        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            txtScore.Text = "Score: " + score;

        }

        
    }
}