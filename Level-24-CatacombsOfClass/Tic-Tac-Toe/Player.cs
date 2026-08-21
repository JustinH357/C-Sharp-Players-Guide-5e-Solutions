namespace Tic_Tac_Toe
{
    internal class Player
    {
        private String PlayerXInput;
        private String PlayerOInput;


        // we are setting the player's input not exactly grabbing the string themselves
        // better to change it to "Set" instead of "Get"
        public String GetPlayerXInput(string playerX) => PlayerXInput = playerX;
        public String GetPlayerOInput(string playerY) => PlayerOInput = playerY;
    }
}
