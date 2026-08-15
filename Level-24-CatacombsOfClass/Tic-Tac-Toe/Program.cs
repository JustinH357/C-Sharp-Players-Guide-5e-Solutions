using Tic_Tac_Toe;

Turn turn = new Turn();

int count = turn.GetCount();

// Game loop
while (true)
{
    if (count % 2 == 0)
    {
        Console.Write("O turn ");
    }
    else
    {
        Console.Write("X turn ");
    }

    GameStart();

    Console.Write("Pick square? ");
    
    // input test
    if (turn.GetInput() == "hi")
    {
        Console.WriteLine("yes!");
    }
    else
    {
        Console.WriteLine("NO!");
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