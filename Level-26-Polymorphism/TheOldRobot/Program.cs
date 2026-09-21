Robot robot = new Robot();

for (int i = 0; i < robot.Commands.Length; i++)
{
    string command = Console.ReadLine();

    if (command == "on")
    {
        OnCommand on = new OnCommand();
        robot.Commands[i] = on;
    }

    if (command == "off")
    {
        OffCommand off = new OffCommand();
        robot.Commands[i] = off;
    }

    if (command == "north")
    {
        NorthCommand north = new NorthCommand();
        robot.Commands[i] = north;
    }

    if (command == "south")
    {
        SouthCommand south = new SouthCommand();
        robot.Commands[i] = south;
    }

    if (command == "west")
    {
        WestCommand west = new WestCommand();
        robot.Commands[i] = west;
    }

    if (command == "east")
    {
        EastCommand east = new EastCommand();
        robot.Commands[i] = east;
    }
}

Console.WriteLine("");

robot.Run();

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3]; // ? just means im accepting or expecting null 
    public void Run()
    {
        foreach (IRobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

// change to interface for lvl 27 challenge. 
public interface IRobotCommand
{
    public void Run(Robot robot);
}

public class OnCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y += 1;
        }
        
    }
}

public class SouthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y += -1;
        }
    }
}
public class WestCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X += -1;
        }
    }
}
public class EastCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X += 1;
        }
    }
}

// Answer this question: Do you feel this is an improvement over using an abstract base class? Why or why not?
// I would say it is an improvement because it free us the need to override an abstract method since we have an interface
// that has the method it needs which we can implement to other classes that does it's own thing. The way I see it is that
// we have a remote control with buttons that is telling the robot what to do base on which command we pick. Simlar to the
// interface concept. 