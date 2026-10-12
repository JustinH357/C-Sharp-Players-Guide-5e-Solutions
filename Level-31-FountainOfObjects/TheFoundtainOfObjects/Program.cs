
using TheFoundtainOfObjects;

Story story = new Story();
Room room = new Room();


Console.WriteLine(story._intro);
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------------------");

while (true)
{
    Console.WriteLine($"You are in the room at (Row={room.row}, Column={room.column})");
    

    string playerInput = Console.ReadLine();

    if (playerInput == "0")
    {
        break;
    }

    room.Move(playerInput);

    if (room.OutofBound())
    {
        Console.WriteLine("Hey! You can't go that way come back!");
        room.DecrementOrIncrementRowOrColumn();
    }


    

    Console.WriteLine("------------------------------------------------------------------------");
}

Console.WriteLine(story._outro);