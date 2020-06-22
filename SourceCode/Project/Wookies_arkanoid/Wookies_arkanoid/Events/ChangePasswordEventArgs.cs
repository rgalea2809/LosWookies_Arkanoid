using System;
using Wookies_arkanoid.Controlador.AppObjects;
using Wookies_arkanoid.Vista;

namespace Wookies_arkanoid.Events
{
    public class ChangePasswordEventArgs : GameEvents
    {
        public override void Event(object sender, EventArgs e, Player player)
        {
            ChangePassword formChangepwd = new ChangePassword();
            formChangepwd.Show();
        }
    }
}