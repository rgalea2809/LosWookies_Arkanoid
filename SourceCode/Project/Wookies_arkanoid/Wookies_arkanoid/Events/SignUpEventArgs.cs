using System;
using Wookies_arkanoid.Controlador.AppObjects;
using Wookies_arkanoid.Vista;

namespace Wookies_arkanoid.Events
{
    public class SignUpEventArgs : GameEvents
    {
        public override void Event(object sender, EventArgs e, Player player)
        {
            Signin formSignup = new Signin();
            formSignup.Show();
        }
    }
}