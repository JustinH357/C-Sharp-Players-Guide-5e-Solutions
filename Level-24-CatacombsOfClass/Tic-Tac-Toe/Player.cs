namespace Tic_Tac_Toe
{
    internal class Player
    {
        //private Player playerX;
        //private Player playerO;
        private String PlayerXInput;
        private String PlayerOInput;

        public Player()
        {
            PlayerXInput = "X";
            PlayerOInput = "O";
        }

        public String GetPlayerXInput(string playerX) => PlayerXInput = playerX;
        public String GetPlayerOInput(string playerY) => PlayerOInput = playerY;
    }
}
