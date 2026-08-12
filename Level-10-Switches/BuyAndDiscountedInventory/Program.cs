// interesting way to use switch expressions, added here for reference.
// challenges discounted and buying inventory from book combined.

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope " +
                "\n2 - Torches " +
                "\n3 - Climbing Equipment " +
                "\n4 - Clean Water" +
                "\n5 - Machete " +
                "\n6 - Canoe " +
                "\n7 - Food Supplies");

Console.Write("What number do you want to see the price of? ");
int number = Convert.ToInt32(Console.ReadLine());

string numberItem = number switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => "This item is not available."
};

double price = numberItem switch
{
    "Rope" => 10,
    "Torches" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supplies" => 1
};

// Discounted Inventory
Console.Write("May I ask for your name also? ");
string name = Console.ReadLine();

if (name == "rai")
    price *= 0.5;

Console.WriteLine($"{numberItem} cost {price} gold.");