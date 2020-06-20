using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Wookies_arkanoid.TOP10
{
    public partial class Top10 : Form
    {
        public Top10()
        {
            InitializeComponent();
            topfill();
        }
        
        private void topfill()
        {
            //Sorting algorithm for top10 scoreboard using linq
            List<userScore> scoreBoard = TopClassDAO.getScores();
            List<userScore> scores = scoreBoard.OrderByDescending(o=>o.playerscore).ToList();

            for (int i = 0; i < scores.Count; i++)
            {
                if (i == 0)
                {
                    user1.Text = scores[i].nickname;
                    score1.Text = scores[i].playerscore.ToString();
                }
                if (i == 1)
                {
                    user2.Text = scores[i].nickname;
                    score2.Text = scores[i].playerscore.ToString();
                }
                if (i == 2)
                {
                    user3.Text = scores[i].nickname;
                    score3.Text = scores[i].playerscore.ToString();
                }
                if (i == 3)
                {
                    user4.Text = scores[i].nickname;
                    score4.Text = scores[i].playerscore.ToString();
                }
                if (i == 4)
                {
                    user5.Text = scores[i].nickname;
                    score5.Text = scores[i].playerscore.ToString();
                }
                if (i == 5)
                {
                    user6.Text = scores[i].nickname;
                    score6.Text = scores[i].playerscore.ToString();
                }
                if (i == 6)
                {
                    user7.Text = scores[i].nickname;
                    score7.Text =scores[i].playerscore.ToString();
                }
                if (i == 7)
                {
                    user8.Text = scores[i].nickname;
                    score8.Text = scores[i].playerscore.ToString();
                }
                if (i == 8)
                {
                    user9.Text = scores[i].nickname;
                    score9.Text = scores[i].playerscore.ToString();
                }
                if (i == 9)
                {
                    user10.Text = scores[i].nickname;
                    score10.Text = scores[i].playerscore.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainMenu = new Form1();
            mainMenu.Show();
            this.Close();
        }
    }
}