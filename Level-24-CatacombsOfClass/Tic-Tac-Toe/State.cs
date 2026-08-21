namespace Tic_Tac_Toe
{
    internal class State
    {
        //private string[,] squares = { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
        private string[,] squares;

        public State()
        {
            //squares = { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };

            squares = new string[3,3];
        }

        public void XSelectSquare(string square)
        {

            if (IsEmpty(square))
            {
                
            }

            if (square == "7")
            {
                squares[0, 0] = "X";
            }
            if (square == "8")
            {
                squares[0, 1] = "X";
            }
            if (square == "9")
            {
                squares[0, 2] = "X";
            }

            

        }

        public void OSelectSquare(string square)
        {

            if (IsEmpty(square))
            {

            }


            if (square == "7")
            {
                squares[0, 0] = "O";
            }
            if (square == "8")
            {
                squares[0, 1] = "O";
            }
            if (square == "9")
            {
                squares[0, 2] = "O";
            }


            
        }

        public void GameState()
        {
            Console.WriteLine(" ");

            Console.WriteLine(squares[0,0] + "   |" + squares[0,1] + "   |" + squares[0,2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   |   |   ");

            Console.WriteLine(" ");
        }


        // logic for a square being filled with X or O, no ideas right now. May have to not do an multi arry but
        // just individual strings for each square then check if they are empty. I can't really check if
        // each multi array are empty. Maybe do a for loop to iterate each element I guess?

        // can probably use this to check if all grids are filled to end loop
        public bool IsSquareFill()
        {
            return squares[0, 0] == "O" || squares[0, 0] == "X" ||
                   squares[0, 1] == "O" || squares[0, 1] == "X" ||
                   squares[0, 2] == "O" || squares[0, 2] == "X";
        }

        //public bool IsEmpty()
        //{
        //    return squares[0, 0] == " " || squares[0, 0] == " " ||
        //           squares[0, 1] == " " || squares[0, 1] == " " ||
        //           squares[0, 2] == " " || squares[0, 2] == " ";
        //}

        public bool IsEmpty(string square)
        {
            if (square == "7" && squares[0, 0] == null)
            {
                return true;
            }
            if (square == "8" && squares[0, 1] == null)
            {
                return true;
            }
            if (square == "9" && squares[0, 2] == null)
            {
                return true;
            }


            return false;
        }
    }
}
