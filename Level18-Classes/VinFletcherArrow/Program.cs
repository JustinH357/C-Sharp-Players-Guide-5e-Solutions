// This challenge was done following the challenges from lvl 18-21 combined.

Console.WriteLine("Hello, would you like to buy custom made or create your own arrow? \n1) Create your own" +
       "\n2) Beginner Arrow \n3) Marksman Arrow \n4) Elite Arrow");
int answer = Convert.ToInt32(Console.ReadLine());

Arrow arrow = answer switch
{
    1 => GetArrows(),
    2 => Arrow.CreateBeginnerArrow(),
    3 => Arrow.CreateMarksmanArrow(),
    4 => Arrow.CreateEliteArrow(),
};

Console.WriteLine($"Your arrow cost: {arrow.GetArrowCost} gold");

Arrow GetArrows()
{
    ArrowheadType arrowhead = SetArrowheadType();
    FletchingType fletching = SetFletchingType();
    float length = SetArrowLength();

    return new Arrow(arrowhead, fletching, length);
}

ArrowheadType SetArrowheadType()
{
    DisplayArrowheadType();
    ArrowheadType currentArrowheadType = (ArrowheadType)Enum.Parse(typeof(ArrowheadType), Console.ReadLine(), true);
    return currentArrowheadType;
}

FletchingType SetFletchingType()
{
    DisplayFletchingType();
    FletchingType currentFletchingType = (FletchingType)Enum.Parse(typeof(FletchingType), Console.ReadLine(), true);
    return currentFletchingType;
}

void DisplayFletchingType()
{
    string[] fletchingName = Enum.GetNames(typeof(FletchingType));
    string fletchingOptions = "";

    foreach (var fletching in fletchingName)
    {
        fletchingOptions += $" '{fletching}' ";
    }

    Console.WriteLine($"What type of arrowhead? {fletchingOptions}");
}

void DisplayArrowheadType()
{
    string[] arrowheadNames = Enum.GetNames(typeof(ArrowheadType));
    string arrowheadOptions = "";

    foreach (var arrowheads in arrowheadNames)
    {
        arrowheadOptions += $" '{arrowheads}' ";
    }

    Console.WriteLine($"What type of arrowhead? {arrowheadOptions} ");
}

float SetArrowLength()
{
    Console.WriteLine($"Choose between 60 and 100 for your arrow length? ");
    float number = float.Parse(Console.ReadLine());
    return number;
}

class Arrow
{
    public ArrowheadType _arrowheadType { get; }
    public FletchingType _fletchingType { get; }
    public float _arrowLength { get; }

    //public Arrow() { }

    public Arrow(ArrowheadType arrowheadType, FletchingType fletchingType, float arrowLength)
    {
        _arrowheadType = arrowheadType;
        _fletchingType = fletchingType;
        _arrowLength = arrowLength;
    }

    public float GetArrowCost()
    {
        float arrowheadCost = _arrowheadType switch
        {
            ArrowheadType.Steel => 10,
            ArrowheadType.Obsidian => 5,
            ArrowheadType.Wood => 3
        };

        float fletchingCost = _fletchingType switch
        {
            FletchingType.Plastic => 10,
            FletchingType.TurkeyFeathers => 5,
            FletchingType.GooseFeathers => 3
        };

        float lengthCost = _arrowLength * 0.05f;


        return arrowheadCost + fletchingCost + lengthCost;
    }

    // There was no need to create a method to get the arrrowhead, fletching, length to return.
    public static Arrow CreateBeginnerArrow() => new Arrow(ArrowheadType.Wood, FletchingType.GooseFeathers, 75);
    public static Arrow CreateMarksmanArrow() => new Arrow(ArrowheadType.Steel, FletchingType.Plastic, 95);
    public static Arrow CreateEliteArrow() => new Arrow(ArrowheadType.Steel, FletchingType.Plastic, 95);
}

// getter methods \\
//private ArrowheadType GetArrowheadType() => _arrowheadType;
//private FletchingType GetFletchingType() => _fletchingType;
//private float GetArrowLength() => _arrowLength;


enum ArrowheadType { Steel, Wood, Obsidian }
enum FletchingType { Plastic, TurkeyFeathers, GooseFeathers }