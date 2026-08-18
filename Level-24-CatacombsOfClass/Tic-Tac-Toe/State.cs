namespace Tic_Tac_Toe
{
    internal class State
    {
        private bool isFill;

        public State(bool isFill)
        {
        }

        // want to have some logic that knows what square is filled within the board/grid
        // my current solution or what i have in mind didn't take into consideration that manually printing the
        // X and O repeating the grid means it will override whatever options X and O choose. I need a logic that 
        // can set the X and O within the grid without losing what X or O previous chose for their square last turn
        // have a few ideas for the logic but thats like a ton of conditional statements and if loops of like 27 different
        // combinations of the grid/board

    }
}
