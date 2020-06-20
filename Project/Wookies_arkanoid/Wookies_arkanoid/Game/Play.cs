using System;
using System.Drawing;
using System.Windows.Forms;
using Wookies_arkanoid.Controlador.AppObjects;
using Wookies_arkanoid.TOP10;

namespace Wookies_arkanoid.Game
{
    public partial class Play : Form
    {
        private DesignPictureBox[,] dpb;
        private PictureBox ball;
        private Label score;
        private Label lives;
        private int countScore = 000;
        private int hearts = 3;
        private int blockCant = 72;
        private Player player;
        
        public Play(Player p)
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            player = p;
            MessageBox.Show("HOW TO PLAY?\n- Move the bar with your mouse pointer\n" +
                            "- Press SPACE BAR to release the ball\n-Have Fun!");
        }

        //Este evento sirve para que cuando ejecutemos el programa y esta ventana se ejecute, aparezcan todos los
        //elementos creados en el.
        private void Play_Load(object sender, EventArgs e)
        {
            
            //Creacion de los label y picture box que se utilizaran en la ventana(Player,Ball,Lives).
            picPlay1.BackgroundImage = Image.FromFile("../../Img/Player.png");
            picPlay1.BackgroundImageLayout = ImageLayout.Stretch;

            picPlay1.Top = (Height - picPlay1.Height) - 100;
            picPlay1.Left = (Width / 2) - (picPlay1.Width / 2);
            
            picPlay2.BackgroundImage = Image.FromFile("../../Img/Heart.png");
            picPlay2.BackgroundImageLayout = ImageLayout.Stretch;
            
            score = new Label();
            score.Size = new Size(220, 60);
            score.Location = new Point((Width - score.Width) - 100);
            score.Text = $"Score: {countScore}";
            score.TextAlign = ContentAlignment.MiddleCenter;
            score.Font = new System.Drawing.Font("Comic Sans MS", 22,FontStyle.Bold, 
                GraphicsUnit.Point, ((0)));
            score.ForeColor = Color.White;
            Controls.Add(score);
            score.BackColor = Color.Transparent;
            
            lives = new Label();
            lives.Size = new Size(99, 69);
            lives.Location = new Point(100, -9);
            lives.Text = $"{hearts}";
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

            ball.Top = picPlay1.Top - ball.Height;
            ball.Left = picPlay1.Left + (picPlay1.Width / 2) - (ball.Width / 2);

            Controls.Add(ball);

            LoadBricks();

            tmrPlay.Start();
        }
        
        //Metodo para recargar una ventana nueva, cuando el jugador reinicia el juego, ya sea porque perdio todas
        //sus vidas o termino y quiere jugar de nuevo.
        private void ReloadGame()
        {
            lives.Text = $"{hearts}";
            ball = new PictureBox();
            ball.Width = ball.Height = 40;
            ball.BackgroundImage = Image.FromFile("../../Img/pelota.png");
            ball.BackgroundImageLayout = ImageLayout.Stretch;
            ball.BackColor = Color.Transparent;
            ball.Top = picPlay1.Top - ball.Height;
            ball.Left = picPlay1.Left + (picPlay1.Width / 2) - (ball.Width / 2);
            Controls.Add(ball);
        }
        
        //Metodo que crea a la matriz de bloques de picture Box.
        private void LoadBricks()
        {
            //12,6
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

                    if (i == 0 || i == 5)
                    {
                        dpb[i, j].Golpes = 2;
                    }
                    else
                    {
                        dpb[i, j].Golpes = 1;
                    }
                    
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

        //Evento para que al mover el mouse de izquierda a derecha el Player o base se mueva tambien.
        private void Play_MouseMove(object sender, MouseEventArgs e)
        {
            if (!DataGame.startGame)
            {
                if (e.X < (Width - picPlay1.Width))
                    picPlay1.Left = e.X;
                ball.Left = picPlay1.Left + (picPlay1.Width / 2) - (ball.Width / 2);
            }
            else
            {
                if (e.X < (Width - picPlay1.Width))
                    picPlay1.Left = e.X;
            }
        }

        //Evento para empezar el juego al dar Enter.
        private void Play_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)

                DataGame.startGame = true;
        }

        //El timer permite que el juego funcione o por decirlo asi, se anime y ejecute el movimeinto de la bola.
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!DataGame.startGame)
                return;
            ball.Left += DataGame.dirX;
            ball.Top += DataGame.dirY;

            bounceBall(sender, e);
        }
        
        //Metodo que permite el funcionamiento y moviemnto de la bola.
        private void bounceBall(object sender, EventArgs e)
        {
            score.Text = "Score :" + countScore;
            lives.Text = $"{hearts}";

            //si la bola toca el suelo:
            if (ball.Bottom > Height)
            {
                if (hearts > 0)
                {
                    hearts--;
                    if (hearts == 0)
                    {
                        ReloadGame();
                        DataGame.startGame =false;
                        int finalScore = countScore + (hearts * 10);
                        gameEnded(finalScore, countScore, hearts);
                        
                    }
                    else if(hearts >0)
                    {
                        ReloadGame();
                        DataGame.startGame =false;
                        MessageBox.Show("Try Again!");
                    }
                }
            }

            //Para que la bola rebote en los bordes y no se salga de ellos.
            if (ball.Bottom < Top +105)
            {
                DataGame.dirY = -DataGame.dirY;
            }
               

            if (ball.Left < 0 || ball.Right > Width)
            {
                DataGame.dirX = -DataGame.dirX;
                return;
            }

            //En este if anidado,permite hacer que los bloques se eliminen, cuando la bola
            //choca con alguno de ellos.
            if (ball.Bounds.IntersectsWith(picPlay1.Bounds))
                
                DataGame.dirY = -DataGame.dirY;
           
            for (int i = 5 ; i >= 0 ; i--)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (ball.Bounds.IntersectsWith(dpb[i, j].Bounds))
                    {
                        if (dpb[i, j].Golpes > 0)
                        {
                            DataGame.dirY = -DataGame.dirY;
                            dpb[i, j].Golpes--;

                            if (dpb[i, j].Golpes == 0)
                            {
                                
                                //Agregar mas puntos dependiendo del color del bloque.
                                if (i== 4)
                                {
                                    countScore++;
                                }
                                if (i == 3)
                                {
                                    countScore+=2;
                                }
                                if (i == 2)
                                {
                                    countScore += 3;
                                }
                                if (i == 1)
                                {
                                    countScore += 3;
                                }
                                if (i == 0)
                                {
                                    countScore += 1;
                                }
                                Controls.Remove(dpb[i, j]);
                                countScore++;
                                blockCant--;
                                if (blockCant == 0)
                                {
                                    ReloadGame();
                                    DataGame.startGame =false;
                                    int finalScore = countScore + (hearts * 10);
                                    gameEnded(finalScore, countScore, hearts);
                                }
                            }
                        }
                    }
                }
            }
        }

        //Metodo que al terminar el juego le da los puntajes ontenidos al jugador, tambien permite que el jugador
        //elija si quiere jugar nuevamente o no.
        private void gameEnded(int totalScore, int score, int hearts)
        {
            string message = $"You Scored:\nHearts ({hearts}) x 10 pts.\n" +
                             $"ScorePoints= {countScore} pts.\n TOTAL: {totalScore} pts! \n" +
                             $"Do you want to play again?";  
            string title = hearts >0 ? "GG EZ!":"GAME OVER";
            TopClassDAO.AddtoScoreboard(player.nickname, totalScore);
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;  
            DialogResult result = MessageBox.Show(message, title, buttons);  
            if (result == DialogResult.Yes) {
                DataGame.startGame =false;
                Play newGame = new Play(player);
                this.Close();
                newGame.Show();
            } else {  
                DataGame.startGame =false;
                Form1 mainMenu = new Form1();
                mainMenu.Show();
                this.Close();
            }
        }
    }
}