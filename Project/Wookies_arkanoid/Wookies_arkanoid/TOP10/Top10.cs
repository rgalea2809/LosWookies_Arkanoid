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
            List<TopClass> filltop1 = TopClassDAO.topget1();
            List<TopClass> filltop2 = TopClassDAO.topget2();
            List<TopClass> filltop3 = TopClassDAO.topget3();
            List<TopClass> filltop4 = TopClassDAO.topget4();
            List<TopClass> filltop5 = TopClassDAO.topget5();
            List<TopClass> filltop6 = TopClassDAO.topget6();
            List<TopClass> filltop7 = TopClassDAO.topget7();
            List<TopClass> filltop8 = TopClassDAO.topget8();
            List<TopClass> filltop9 = TopClassDAO.topget9();
            List<TopClass> filltop10 = TopClassDAO.topget10();
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filltop1;
            
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = filltop2;
            
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = filltop3;
            
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = filltop4;
            
            dataGridView5.DataSource = null;
            dataGridView5.DataSource = filltop5;
            
            dataGridView6.DataSource = null;
            dataGridView6.DataSource = filltop6;
            
            dataGridView7.DataSource = null;
            dataGridView7.DataSource = filltop7;
            
            dataGridView8.DataSource = null;
            dataGridView8.DataSource = filltop8;
            
            dataGridView9.DataSource = null;
            dataGridView9.DataSource = filltop9;
            
            dataGridView10.DataSource = null;
            dataGridView10.DataSource = filltop10;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}