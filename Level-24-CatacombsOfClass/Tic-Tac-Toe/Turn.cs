namespace Tic_Tac_Toe
{
    internal class Turn
    {
        // can count the turns to keep track, odd turns = player X & even turns = player O
        private int count;
        private bool xTurn;
        private bool oTurn;

        public Turn()
        {
            count = 1;
            xTurn = false;
            oTurn = false;
        }

        public int GetCount() => count;

        // going to need to get separate inputs or just use player class that has the separate input for X and O
        public String GetInput()
        {
            Player player = new Player();

            if (count % 2 == 0) // even is player O
            {
                return player.GetPlayerOInput(Console.ReadLine());
            }
            else
            {
                return player.GetPlayerXInput(Console.ReadLine());
            }
        }

        public void whoseTurn(int count)
        {
            if (count % 2 == 0)
            {
                Console.Write("O turn ");
                oTurn = true;
            }
            else
            {
                Console.Write("X turn ");
                xTurn = true;
            }
        }

        public bool isXTurn() => xTurn;
        public bool isOTurn() => oTurn;
    }
}
