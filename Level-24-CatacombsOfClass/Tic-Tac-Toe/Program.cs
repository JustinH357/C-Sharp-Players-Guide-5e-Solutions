using Tic_Tac_Toe;

Turn turn = new Turn();
State state = new State();
Player player = new Player();

while (true)
{
    turn.WhoseTurn();

    state.GameState();

    Console.Write("Pick square? ");

    if (turn.IsXTurn())
    {
        player.PlayerXInput = Console.ReadLine();
        state.XSelectSquare(player.PlayerXInput);
    }

    if (turn.IsOTurn())
    {
        player.PlayerOInput = Console.ReadLine();
        state.OSelectSquare(player.PlayerOInput);
    }

    turn.Increment();

    // go back a turn if a square is taken
    if (state.GetNotEmpty())
    {
        Console.WriteLine("This grid is already taken!");
        turn.Decrement();
    }

    // if all sqaures are filled then that means no winner
    if (state.IsSquareFill())
    {
        break;
    }

    if (state.GameOutcome())
    {
        break;
    }

    Console.WriteLine("----------------------");
}

state.GameState(); // display the final state of the game to see who won or how they won
Console.WriteLine(state.WhoWon()); 

