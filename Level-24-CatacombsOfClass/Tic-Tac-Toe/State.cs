namespace Tic_Tac_Toe
{
    internal class State
    {
        private string[,] squares;
        private bool notEmpty;
        private int xWinCount;
        private int oWinCount;

        public State()
        {
            squares = new string[3,3];
            notEmpty = false;
            xWinCount = 0;
            oWinCount = 0;
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
            else if (square == "7")
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
        }

        public void GameState()
        {
            Console.WriteLine(" ");

            Console.WriteLine(squares[0, 0] + "   |" + squares[0, 1] + "   |" + squares[0, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(squares[1, 0] + "   |" + squares[1, 1] + "   |" + squares[1, 2]);
            Console.WriteLine("-----------");
            Console.WriteLine(squares[2, 0] + "   |" + squares[2, 1] + "   |" + squares[2, 2]);

            Console.WriteLine(" ");
        }

        public bool IsSquareFill()
        {
            return squares[0, 0] != null && squares[0, 1] != null && squares[0, 2] != null &&
                   squares[1, 0] != null && squares[1, 1] != null &&  squares[1, 2] != null &&
                   squares[2, 0] != null && squares[2, 1] != null &&  squares[2, 2] != null;
        }

        public bool IsNotEmpty(string square)
        {
            if (square == "7")
            {
                return squares[0, 0] != null;
            }
            if (square == "8")
            {
                return squares[0, 1] != null;
            }
            if (square == "9")
            {
                return squares[0, 2] != null;
            }
            if (square == "4")
            {
                return squares[1, 0] != null;
            }
            if (square == "5")
            {
                return squares[1, 1] != null;
            }
            if (square == "6")
            {
                return squares[1, 2] != null;
            }
            if (square == "1")
            {
                return squares[2, 0] != null;
            }
            if (square == "2")
            {
                return squares[2, 1] != null;
            }
            if (square == "3")
            {
                return squares[2, 2] != null;
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

        public bool GameOutcome()
        {
            // conditions to check if the 3 rows horizontally are the same
            bool topRowO = squares[0,0] == "O" && squares[0,1] == "O" && squares[0, 2] == "O";
            bool midRowO = squares[1, 0] == "O" && squares[1, 1] == "O" && squares[1, 2] == "O";
            bool bottomRowO = squares[2, 0] == "O" && squares[2, 1] == "O" && squares[2, 2] == "O";

            bool topRowX = squares[0, 0] == "X" && squares[0, 1] == "X" && squares[0, 2] == "X";
            bool midRowX = squares[1, 0] == "X" && squares[1, 1] == "X" && squares[1, 2] == "X";
            bool bottomRowX = squares[2, 0] == "X" && squares[2, 1] == "X" && squares[2, 2] == "X";

            // conditions to check if 3 rows vertically are the same
            bool topColumnO = squares[0, 0] == "O" && squares[1, 0] == "O" && squares[2, 0] == "O";
            bool midColumnO = squares[0, 1] == "O" && squares[1, 1] == "O" && squares[2, 1] == "O";
            bool bottomColumnO = squares[0, 2] == "O" && squares[1, 2] == "O" && squares[2, 2] == "O";

            bool topColumnX = squares[0, 0] == "X" && squares[1, 0] == "X" && squares[2, 0] == "X";
            bool midColumnX = squares[0, 1] == "X" && squares[1, 1] == "X" && squares[2, 1] == "X";
            bool bottomColumnX = squares[0, 2] == "X" && squares[1, 2] == "X" && squares[2, 2] == "X";

            // conditions to check if the squares diagonally are the same
            bool leftDiagonalO = squares[0, 0] == "O" && squares[1, 1] == "O" && squares[2, 2] == "O";
            bool rightDiagonalO = squares[0, 2] == "O" && squares[1, 1] == "O" && squares[2, 0] == "O";

            bool leftDiagonalX = squares[0, 0] == "X" && squares[1, 1] == "X" && squares[2, 2] == "X";
            bool rightDiagonalX = squares[0, 2] == "X" && squares[1, 1] == "X" && squares[2, 0] == "X";


            // checking for O and X win condition horizontally
            if (topRowO)
            {
                oWinCount++;
                return true;
            }
            if (midRowO)
            {
                oWinCount++;
                return true;
            }
            if (bottomRowO)
            {
                oWinCount++;
                return true;
            }

            if (topRowX)
            {
                xWinCount++;
                return true;
            }
            if (midRowX)
            {
                xWinCount++;
                return true;
            }
            if (bottomRowX)
            {
                xWinCount++;
                return true;
            }

            // checking for O and X win condition vertically
            if (topColumnO)
            {
                oWinCount++;
                return true;
            }
            if (midColumnO)
            {
                oWinCount++;
                return true;
            }
            if (bottomColumnO)
            {
                oWinCount++;
                return true;
            }

            if (topColumnX)
            {
                xWinCount++;
                return true;
            }
            if (midColumnX)
            {
                xWinCount++;
                return true;
            }
            if (bottomColumnX)
            {
                xWinCount++;
                return true;
            }

            // checking for O and X win condition diagonally 
            if (leftDiagonalO)
            {
                oWinCount++;
                return true;
            }
            if (rightDiagonalO)
            {
                oWinCount++;
                return true;
            }

            if (leftDiagonalX)
            {
                xWinCount++;
                return true;
            }
            if (rightDiagonalX)
            {
                xWinCount++;
                return true;
            }

            return false;
        }

        public string WhoWon()
        {
            if (xWinCount > 0)
            {
                return "X is the winner!";
            }

            if (oWinCount > 0)
            {
                return "O is the winner!";
            }
            
            return "No winner. Draw.";
        }
    }
}
