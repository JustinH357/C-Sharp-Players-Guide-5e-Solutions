Color colorChannel = new Color(red: ("Red", 255, 0, 0), green: ("Green", 0, 128, 0), blue: ("Blue", 0, 0, 255));
Console.WriteLine($"{colorChannel._red.Name} ({colorChannel._red.Item2},{colorChannel._red.Item3},{colorChannel._red.Item4})");
Console.WriteLine($"{colorChannel._green.Name} ({colorChannel._green.Item2},{colorChannel._green.Item3},{colorChannel._green.Item4})");
Console.WriteLine($"{colorChannel._blue.Name} ({colorChannel._blue.Item2},{colorChannel._blue.Item3},{colorChannel._blue.Item4})");

// static property
Console.WriteLine($"{Color.white.Name} ({Color.white.Item2},{Color.white.Item3},{Color.white.Item4})");

class Color
{
    public (string Name, int, int, int) _red { get; }
    public (string Name, int, int, int) _green { get; }
    public (string Name, int, int, int) _blue { get; }

    // 8 common use colors
    public static (string Name, int, int, int) white = ("White",255,255,255);
    public static (string Name, int, int, int) black = ("Black",0,0,0);
    public static (string Name, int, int, int) yellow = ("Yellow",255,255,0);
    public static (string Name, int, int, int) orange = ("Orange",255,165,0);
    public static (string Name, int, int, int) pink = ("Pink",255, 192, 203);
    public static (string Name, int, int, int) brown = ("Brown",165, 42, 42);
    public static (string Name, int, int, int) gray = ("Gray",128, 128, 128);
    public static (string Name, int, int, int) purple = ("Purple",128,0,128);

    public Color((string, int,int,int) red, (string, int, int, int) green, (string, int, int, int) blue)
    {
        _red = red;
        _green = green;
        _blue = blue;
    }
}

// Misunderstood this challenge. Author wanted us to treat it as a RGB color selector which I ended up thinking he meant
// choosing the actual color value for each color. He did showed an example but it still didn't register to me. 
// Will have to take a look at this again. 
