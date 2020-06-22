namespace Wookies_arkanoid.TOP10
{
    public class userScore
    {
        //Object used in the TOP10 Menu
        public string nickname{ get; set; }
        public int playerscore { get; set; }
        
        public userScore()
        {
            nickname = "";
            playerscore = 0;
        }
    }
}