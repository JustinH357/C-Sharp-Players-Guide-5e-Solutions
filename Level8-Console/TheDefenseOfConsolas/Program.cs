Console.Title = "Defense of Consolas";

Console.WriteLine("Target Row?");
int rowNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Target Column?");
int columnNumber = Convert.ToInt32(Console.ReadLine());

ConsolasDelpoyment(rowNumber, columnNumber);

void ConsolasDelpoyment(int rowNumber, int columnNumber)
{
    //Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Red;

    // ex (6,5) - top (6, 5+1) = 6,6 | bottom (6, 5-1) = 6,4
    // left (6-1, 5) = 5,5 | right (6+1, 5) = 7,5
    // (x,y)

    Console.WriteLine($"Deploy to: " +
        $"\n\"{rowNumber},{columnNumber - 1}\"" +
        $"\n\"{rowNumber - 1},{columnNumber}\"" +
        $"\n\"{rowNumber},{columnNumber + 1}\"" +
        $"\n\"{rowNumber + 1},{columnNumber}\""); // deployment from top, left, bottom, right

    Console.Beep();
}
