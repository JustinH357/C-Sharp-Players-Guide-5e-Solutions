namespace Tic_Tac_Toe
{
    internal class State
    {
        private string[,] squares;
        private bool notEmpty;

        public State()
        {
            squares = new string[3,3];
            notEmpty = false;
        }

        public void XSelectSquare(string square)
        {
            // using else if loop so the condition to check if a grid IsNotEmpty() first without
            // triggering the other conditions. 
            // having the other conditions SquareNotEmpty() to false works but its being repeated multiple times.
            // must be a better way to handle this. 

            if (IsNotEmpty(square))
            {
                SquareNotEmpty(true);
            }
            else if(square == "7")
            {
                squares[0, 0] = "X";
                SquareNotEmpty(false);
            }
            else if(square == "8")
            {
                squares[0, 1] = "X";
                SquareNotEmpty(false);
            }
            else if(square == "9")
            {
                squares[0, 2] = "X";
                SquareNotEmpty(false);
            }
            else if (square == "4")
            {
                squares[1, 0] = "X";
                SquareNotEmpty(false);
            }
            else if (square == "5")
            {
                squares[1, 1] = "X";
                SquareNotEmpty(false);
            }
            else if (square == "6")
            {
                squares[1, 2] = "X";
                SquareNotEmpty(false);
            }
            else if (square == "1")
            {
                squares[2, 0] = "X";
                SquareNotEmpty(false);
            }
            else if (square == "2")
            {
                squares[2, 1] = "X";
                SquareNotEmpty(false);
            }
            else if (square == "3")
            {
                squares[2, 2] = "X";
                SquareNotEmpty(false);
            }
        }

        public void OSelectSquare(string square)
        {

            if (IsNotEmpty(square))
            {
                SquareNotEmpty(true);
            }
            else if (square == "7")
            {
                squares[0, 0] = "O";
                SquareNotEmpty(false);
            }
            else if(square == "8")
            {
                squares[0, 1] = "O";
                SquareNotEmpty(false);
            }
            else if(square == "9")
            {
                squares[0, 2] = "O";
                SquareNotEmpty(false);
            }
            else if (square == "4")
            {
                squares[1, 0] = "O";
                SquareNotEmpty(false);
            }
            else if (square == "5")
            {
                squares[1, 1] = "O";
                SquareNotEmpty(false);
            }
            else if (square == "6")
            {
                squares[1, 2] = "O";
                SquareNotEmpty(false);
            }
            else if (square == "1")
            {
                squares[2, 0] = "O";
                SquareNotEmpty(false);
            }
            else if (square == "2")
            {
                squares[2, 1] = "O";
                SquareNotEmpty(false);
            }
            else if (square == "3")
            {
                squares[2, 2] = "O";
                SquareNotEmpty(false);
            }

            // separate check instead of repeating squarenotempty false multiple times
            // need to check if this works
            if (!IsNotEmpty(square))
            {
                SquareNotEmpty(false);
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

        // can probably use this to check if all grids are filled to end loop
        public bool IsSquareFill()
        {
            return squares[0, 0] == "O" || squares[0, 0] == "X" &&
                   squares[0, 1] == "O" || squares[0, 1] == "X" &&
                   squares[0, 2] == "O" || squares[0, 2] == "X";
        }

        public bool IsNotEmpty(string square)
        {
            if (square == "7")
            {
                return squares[0,0] != null;
            }
            if (square == "8")
            {
                return squares[0, 1] != null;
            }
            if (square == "9")
            {
                return squares[0, 2] != null;
            }


            return false;
        }

        public bool SquareNotEmpty(bool notEmpty)
        {
            if (notEmpty)
            {
                return this.notEmpty = true;
            }

            return this.notEmpty = false;
        }

        public bool GetNotEmpty() => notEmpty;
    }
}
