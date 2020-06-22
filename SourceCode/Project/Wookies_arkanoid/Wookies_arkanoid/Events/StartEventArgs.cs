using System;
using Wookies_arkanoid.Controlador.AppObjects;
using Wookies_arkanoid.Game;

namespace Wookies_arkanoid.Events
{
    public class StartEventArgs : GameEvents
    {
        public override void Event(object sender, EventArgs e, Player player)
        {
            //Start Game
            Play formGame = new Play(player);
            formGame.Show();
        }
    }
}