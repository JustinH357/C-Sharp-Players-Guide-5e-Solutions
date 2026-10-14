
using TheFoundtainOfObjects;

Story story = new Story();
Room room = new Room();
//State roomState = new State();


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

    if (room.OutOfBoundCheck())
    {
        Console.WriteLine("Hey! You can't go that way come back!");
        room.OutOfBoundComeback();
    }

    room.Details();


    

    Console.WriteLine("------------------------------------------------------------------------");
}

// check if the win logic work
if (State.OutcomeCheck())
{
    Console.WriteLine(story._outro);
}
else
{
    Console.WriteLine("You failed!");
}
