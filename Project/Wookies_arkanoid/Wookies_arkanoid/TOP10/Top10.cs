using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            List<userScore> scoreBoard = TopClassDAO.getScores();

            Stack<userScore> stack = new Stack<userScore>();
            Stack<userScore> stackAux = new Stack<userScore>();
            
            foreach (var user in scoreBoard)
            {
                if (stack.Count == 0)
                {
                    stack.Push(user);
                }
                else
                {
                    bool larger = true;
                    while (larger)
                    {
                        if (stack.Peek().playerscore >= user.playerscore)
                        {
                            stackAux.Push(stack.Pop());
                            break;
                        }
                        stack.Push(user);
                        larger = false;
                    }

                    for (int i = 0; i < stackAux.Count; i++)
                    {
                        stack.Push(stackAux.Pop());
                    }
                }
            }
            var clonedStack = new Stack<userScore>(new Stack<userScore>(stack));
            for (int i = 0; i < stack.Count; i++)
            {
                if (i == 0)
                {
                    user1.Text = clonedStack.Peek().nickname;
                    score1.Text = Convert.ToString(clonedStack.Pop().playerscore);
                }
                if (i == 1)
                {
                    user2.Text = clonedStack.Peek().nickname;
                    score2.Text = Convert.ToString(clonedStack.Pop().playerscore);
                }
                if (i == 2)
                {
                    user3.Text = clonedStack.Peek().nickname;
                    score3.Text = Convert.ToString(clonedStack.Pop().playerscore);
                }
                if (i == 3)
                {
                    user4.Text = clonedStack.Peek().nickname;
                    score4.Text = Convert.ToString(clonedStack.Pop().playerscore);
                }
                if (i == 4)
                {
                    user5.Text = clonedStack.Peek().nickname;
                    score5.Text = Convert.ToString(clonedStack.Pop().playerscore);
                }
                if (i == 5)
                {
                    user6.Text = clonedStack.Peek().nickname;
                    score6.Text = Convert.ToString(clonedStack.Pop().playerscore);
                }
                if (i == 6)
                {
                    user7.Text = clonedStack.Peek().nickname;
                    score7.Text = Convert.ToString(clonedStack.Pop().playerscore);
                }
                if (i == 7)
                {
                    user8.Text = clonedStack.Peek().nickname;
                    score8.Text = Convert.ToString(clonedStack.Pop().playerscore);
                }
                if (i == 8)
                {
                    user9.Text = clonedStack.Peek().nickname;
                    score9.Text = Convert.ToString(clonedStack.Pop().playerscore);
                }
                if (i == 9)
                {
                    user10.Text = clonedStack.Peek().nickname;
                    score10.Text = Convert.ToString(clonedStack.Pop().playerscore);
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