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
    public RobotCommand?[] Commands { get; } = new RobotCommand?[3]; // ? just means im accepting or expecting null 
    public void Run()
    {
        foreach (RobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

public abstract class RobotCommand
{
    public abstract void Run(Robot robot);
}

public class OnCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

public class NorthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y += 1;
        }
        
    }
}

public class SouthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y += -1;
        }
    }
}
public class WestCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X += -1;
        }
    }
}
public class EastCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.X += 1;
        }
    }
}