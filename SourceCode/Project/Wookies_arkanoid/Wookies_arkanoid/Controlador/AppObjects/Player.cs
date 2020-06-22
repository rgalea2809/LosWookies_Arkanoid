namespace Wookies_arkanoid.Controlador.AppObjects
{
    public class Player
    {
        //Object used throughout the game, to identify the player
        public string nickname { get; set; }
        public string password { get; set; }

        public Player()
        {
            nickname = "";
            password = " ";
        }
    }
}