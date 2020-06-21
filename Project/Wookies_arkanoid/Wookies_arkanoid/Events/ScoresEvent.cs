using System;
using Wookies_arkanoid.Controlador.AppObjects;
using Wookies_arkanoid.TOP10;

namespace Wookies_arkanoid.Events
{
    public class ScoresEvent : GameEvents
    {
        public override void Event(object sender, EventArgs e, Player player)
        {
            Top10 FormTop10 = new Top10();
            FormTop10.Show();
        }
    }
}