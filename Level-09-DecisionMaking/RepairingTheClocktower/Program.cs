
Console.WriteLine("Please type a number:");
bool answer = Convert.ToInt32(Console.ReadLine()) % 2 == 0;

if (answer)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}