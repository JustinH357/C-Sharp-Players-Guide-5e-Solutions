Console.WriteLine("How many eggs collected?");
var answer = Console.ReadLine();

Console.WriteLine($"You have a total of {answer} eggs.");
Console.WriteLine("Calculating the split for the eggs...");

var eggNumber = Convert.ToInt32(answer) / 4;
var eggRemainder = Convert.ToInt32(answer) % 4;

Console.WriteLine($"The sisters get {eggNumber} each and the duckbear gets {eggRemainder} left over.");
