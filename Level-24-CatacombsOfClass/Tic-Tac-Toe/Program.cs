using Tic_Tac_Toe;

Turn turn = new Turn();
State state = new State();
Player player = new Player();


// could add a logic that exit the loop once all the squares within the grid is filled
// then check who the winner is

while (true)
{
    turn.WhoseTurn();

    state.GameState();

    Console.Write("Pick square? ");

    if (turn.IsXTurn())
    {
        state.XSelectSquare(player.GetPlayerXInput(Console.ReadLine()));
    }

    if (turn.IsOTurn())
    {
        state.OSelectSquare(player.GetPlayerOInput(Console.ReadLine()));
    }

    // go back a turn if grid is filled/taken else proceed to the next turn
    // currently this condition is always true when it detects a filled grid

    turn.Increment();

    if (state.GetNotEmpty())
    {
        Console.WriteLine("This grid is already taken!");
        turn.Decrement();
    }


    // currently when the winner is determine it doesn't update the board to the grids that have all matching Os or Xs
    if (state.GameOutcome())
    {
        break;
    }

    // check the turns to see for any bugs
    //Console.WriteLine("Turns: " + turn.GetCount());

    Console.WriteLine("----------------------");
}

Console.WriteLine("We got a winner!"); // check if break works
