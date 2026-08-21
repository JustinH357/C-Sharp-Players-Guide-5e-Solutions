namespace Tic_Tac_Toe
{
    internal class Turn
    {
        private int count;

        public Turn()
        {
            count = 1; // for X to start first
        }

        public int Increment() => count++;

        public void WhoseTurn()
        {
            if (count % 2 == 0)
            {
                Console.Write("O turn ");
            }
            else
            {
                Console.Write("X turn ");
            }
        }

        public bool IsXTurn()
        {
            if (count % 2 != 0)
            {
                return true;
            }

            return false;
        }

        public bool IsOTurn()
        {
            if (count % 2 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
