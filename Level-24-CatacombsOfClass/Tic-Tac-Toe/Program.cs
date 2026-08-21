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

    turn.Increment();
}
