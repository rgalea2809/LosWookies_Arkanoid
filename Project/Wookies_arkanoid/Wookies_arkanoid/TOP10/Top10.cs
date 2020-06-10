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
                    bool isLarger = true;
                    while (isLarger)
                    {
                        if (stack.Peek().playerscore < user.playerscore)
                        {
                            stackAux.Push(stack.Pop());
                            break;
                        }
                        stack.Push(user);
                        for (int i = 0; i < stackAux.Count; i++)
                        {
                            stack.Push(stackAux.Pop());
                        }

                        isLarger = false;
                    }
                }
            }
            //TODO Implement top 10
            // for (int i = 1; i <= 10; i++)
            // {
            //     dataGridView.DataSource = 
            // }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}