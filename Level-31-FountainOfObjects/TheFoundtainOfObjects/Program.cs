
using TheFoundtainOfObjects;

Story story = new Story();
Room room = new Room();
State state = new State();


Console.WriteLine(story.Intro);
Console.WriteLine();
Console.WriteLine("------------------------------------------------------------------------");

while (true)
{
    Console.WriteLine($"You are in the room at (Row={room.Row}, Column={room.Column})");

    room.Detail();

    //if (room.PitfallLocation())
    //{
    //    break;
    //}

    Console.Write("What do you want to do? ");
    string playerInput = Console.ReadLine();

    if (playerInput == "0")
    {
        break;
    }

    room.EnableOrDisableFountain(playerInput);
    room.Move(playerInput);

    if (room.OutOfBoundCheck())
    {
        Console.WriteLine("Hey! You can't go that way come back!");
        room.OutOfBoundComeback();
    }

    Console.WriteLine("------------------------------------------------------------------------");
}

// check if the win logic work
if (room.OutcomeCheck())
{
    Console.WriteLine(story.Outro);
}
else
{
    Console.WriteLine("Try again.");
}
