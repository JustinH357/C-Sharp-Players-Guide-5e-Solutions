Coordinate a = new Coordinate(1, 2);
Coordinate b = new Coordinate(2, 3);
Coordinate c = new Coordinate(4, 5);
Coordinate d = new Coordinate(1, 3);

bool x = a.IsAdjacent(b);
bool y = b.IsAdjacent(c);
bool z = a.IsAdjacent(d);

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

public struct Coordinate
{
    private readonly int _row { get; }
    private readonly int _column { get; }

    public Coordinate(int row, int column)
    {
        _row = row; 
        _column = column;
    }

    public bool IsAdjacent(Coordinate cord)
    {
        if (_row - cord._row == 1 || _row - cord._row == -1 && _column == cord._column) return true;
        if (_column - cord._column == 1 || _column - cord._column == -1 && _row == cord._row) return true;

        return false;
    }
}