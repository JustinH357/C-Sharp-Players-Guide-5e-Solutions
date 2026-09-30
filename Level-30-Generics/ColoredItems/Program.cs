ColoredItem<Sword> sword = new ColoredItem<Sword>(ConsoleColor.Blue);
ColoredItem<Bow> bow = new ColoredItem<Bow>(ConsoleColor.Red);
ColoredItem<Axe> axe = new ColoredItem<Axe>(ConsoleColor.Green);

sword.Display();
bow.Display();
axe.Display();

public class Sword { }
public class Bow { }
public class Axe { }

public class ColoredItem<TItem> where TItem : new()
{
    public TItem _item { get; } 
    public ConsoleColor _color { get; }

    public ColoredItem(ConsoleColor color)
    {
        _item = new TItem();
        _color = color;
    }

    public void Display()
    {
        Console.ForegroundColor = _color;
        Console.WriteLine(_item.ToString());

    }
}