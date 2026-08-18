using Tic_Tac_Toe;

Turn turn = new Turn();
State state = new State(false);

int count = turn.GetCount();


GameStart(); // the grid/board for starting game, out of loop so it doesn't print every time

// Game loop
while (true)
{
    turn.whoseTurn(count);

    Console.Write("Pick square? ");
    
    // input test
    if (turn.isXTurn())
    {
        if (turn.GetInput() == "1")
        {

            Console.WriteLine("   |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" X |   |   ");
        }
    }

    if (turn.isOTurn())
    {
        if (turn.GetInput() == "5")
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   | O |   ");
            Console.WriteLine("---+---+---");
            Console.WriteLine("   |   |   ");
        }
    }

    // increment the turns
    count++;
}

// Display the squares/board
void GameStart()
{
    Console.WriteLine(" "); // spacing

    Console.WriteLine("   |   |   ");
    Console.WriteLine("---+---+---");
    Console.WriteLine("   |   |   ");
    Console.WriteLine("---+---+---");
    Console.WriteLine("   |   |   ");
}