using System;
using System.Windows.Forms;
using Wookies_arkanoid.Events;
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
            //Go to LogIn Screen
            PlayEvent playEvent = new PlayEvent();
            playEvent.Event(sender, e, null);
            this.Hide();
        }

        private void botonTop10MM_Click(object sender, EventArgs e)
        {
            //Create TOP10 form
            ScoresEvent top10 = new ScoresEvent();
            top10.Event(sender, e, null);
            this.Hide();
        }

        private void ExitMM_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Dispose();
            Application.Exit();
        }
    }
}