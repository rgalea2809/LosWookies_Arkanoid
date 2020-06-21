using System;
using Wookies_arkanoid.Controlador.AppObjects;
using Wookies_arkanoid.Vista;

namespace Wookies_arkanoid.Events
{
    public class PlayEvent : GameEvents
    {
        public override void Event(object sender, EventArgs e, Player player)
        {
            //Create LogIn form
            Login FormLogin = new Login();
            FormLogin.Show();
        }
    }
}