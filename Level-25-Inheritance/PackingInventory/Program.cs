using PackingInventory;

Pack pack = new Pack();
Arrow arrow = new Arrow();
FoodRations foodRations = new FoodRations();
Sword sword = new Sword();
Water water = new Water();
Bow bow = new Bow();
Rope rope = new Rope();

// test ToString to see what it prints for lvl 26 "labeling inventory" challenge
Console.WriteLine(rope);
Console.WriteLine(rope.ToString());
Console.WriteLine(arrow.ToString());


int input;
while (true)
{
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine("Select an item to add to your inventory:" +
        "\n1) Arrow weight of 0.1 and volume of 1.5." +
        "\n2) Bow weight of 1 and volume of 4." +
        "\n3) Rope weight of 1 and volume of 1.5." +
        "\n4) Water weight of 2 and volume of 3." +
        "\n5) Food rations weight of 1 and a volume of 0.5." +
        "\n6) Sword weight of 5 and volume of 3." +
        "\n0) exit.");

    Console.WriteLine(" ");

    Console.WriteLine($"Inventory Info: \nSpace - {pack.currentItem}/{pack.totalItem} " +
                                      $"\nWeight - {pack.currentWeight}/{pack.maxWeight} " +
                                      $"\nVolume - {pack.currentVolume}/{pack.maxVolume} ");

    Console.WriteLine(" ");

    input = Convert.ToInt32(Console.ReadLine());

    // user can choose to exit loop 
    if (input == 0)
    {
        break;
    }

    InventoryItem item = input switch
    {
        1 => arrow,
        2 => bow,
        3 => rope,
        4 => water,
        5 => foodRations,
        6 => sword
    };

    // exit loop when inventory full
    if (pack.Add(item) == false)
    {
        Console.WriteLine("Your inventory is full!");
        break;
    }
}

Console.WriteLine(pack.ToString());
pack.PrintItems();