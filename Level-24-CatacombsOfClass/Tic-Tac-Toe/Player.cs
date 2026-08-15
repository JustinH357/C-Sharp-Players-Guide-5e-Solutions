namespace Tic_Tac_Toe
{
    internal class Player
    {
        //private Player playerX;
        //private Player playerO;
        public String PlayerInput { get; }

        public Player(String  playerInput)
        {
            PlayerInput = playerInput;
        }

        public String GetPlayerInput() => PlayerInput;
    }
}
