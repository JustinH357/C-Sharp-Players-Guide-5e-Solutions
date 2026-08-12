Point point = new Point(2,3);
Console.WriteLine($"({point._xCordinate},{point._yCordinate})");

// point = new Point(-4,0);
// Point otherPoint = new Point(-4,0)
Console.WriteLine($"({point._xCordinate = -4},{point._yCordinate = 0})");

class Point
{
    public int _xCordinate { get; set; }
    public int _yCordinate { get; set;  }

    public Point() : this (0,0) { }

    public Point(int xCord, int yCord)
    {
        _xCordinate = xCord;
        _yCordinate = yCord;
    }
}

// Answer this question: Are your X and Y properties immutable? Why did you choose what you did?
// x and y properties not immutable because if someone wants to change one of the cordinates, they can just set
// it to what number they want for it without needing to touch the other cordinate.

// Author perfers immutable because easy to reason and no reason to make it mutable.
// Should stick to immutable instead since it leads to less problems in the future if someone got hold of the
// properties or the system itself is making weird changes to it that it shouldn't be doing.