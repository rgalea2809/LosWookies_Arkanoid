using System;
using System.Windows.Forms;
using Wookies_arkanoid.TOP10;
using Wookies_arkanoid.Vista;

namespace Wookies_arkanoid
{
    public partial class MainmenuUI : UserControl
    {
        public MainmenuUI()
        {
            InitializeComponent();
        }

        private void botonPlayMM_Click(object sender, EventArgs e)
        {
            Login FormLogin = new Login();
            FormLogin.Show();
            this.Hide();
        }

        private void botonTop10MM_Click(object sender, EventArgs e)
        {
            Top10 FormTop10 = new Top10();
            FormTop10.Show();
            this.Hide();
        }

        private void ExitMM_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Dispose();
            Application.Exit();
        }
    }
}