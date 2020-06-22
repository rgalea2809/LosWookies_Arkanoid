using System;
using Wookies_arkanoid.Controlador.AppObjects;

namespace Wookies_arkanoid.Events
{
    //Abstract Class used for inheritance
    public abstract class GameEvents
    {
        public abstract void Event(Object sender, EventArgs e, Player player);
    }
}