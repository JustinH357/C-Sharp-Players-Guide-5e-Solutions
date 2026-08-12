for (int turn = 1; turn <= 100; turn++)
{
    if (turn % 15 == 0) // 3 * 5 = 15 so find multiples of 15s
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{turn}: Electric and Fire");
    }
    else if (turn % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{turn}: Fire");
    }
    else if (turn % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{turn}: Electric");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{turn}: Normal");
    }
}