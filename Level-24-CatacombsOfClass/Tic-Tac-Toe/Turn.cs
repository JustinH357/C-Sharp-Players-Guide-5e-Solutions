namespace Tic_Tac_Toe
{
    internal class Turn
    {
        // can count the turns to keep track, odd turns = playerX & even turns = playerO


        private int count;

        public Turn()
        {
            count = 1;
        }

        public int GetCount() => count;

        public String GetInput()
        {
            if (count % 2 == 0)
            {
                Player playerO = new Player(Console.ReadLine());
                return playerO.GetPlayerInput();
            }
            else
            {
                Player playerX = new Player(Console.ReadLine());
                return playerX.GetPlayerInput();
            }
        }
    }
}
