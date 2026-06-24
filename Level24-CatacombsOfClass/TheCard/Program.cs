// Could of made an array of both enum then do foreach loop without having to access the enum index.
// Also, no need to cast it like I did in the for loop. 

for (int i = 0; i < 4; i++)
{
    // cast i to enum Color
    Color currentColor = (Color)i;

    Console.WriteLine(" ");
    Console.WriteLine($"{currentColor}:");

    for (int j = 0; j < 14; j++)
    {
        // cast j to enum Rank
        Rank currentRank = (Rank)j;
        Card card = new Card(currentColor, currentRank);

        Console.WriteLine($"The {card._color} {card._rank} {card.CardType(currentRank)}");
    }
}

class Card
{
    // need to get use to constructors and properties
    // re-read constructor section and learn more online if needed
    public Color _color { get; }
    public Rank _rank { get; }

    public Card(Color color, Rank rank)
    {
        _color = color;
        _rank = rank;
    }


    // Author seems to mean to return true if symbol, false if not. At least that is what he did. 
    public string CardType(Rank card)
    {
        // Rank 0-9 are all numbers
        if (card <= (Rank)9 && card >= 0)
            return "- number card";
        else
            return "- symbol card";
    }
    
}

enum Color { Red, Green, Blue, Yellow }
// have to use letters/words - numbers and special characters dont work for enums
enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Caret, Ampersand }

// Answer this question: Why do you think we used a color enumeration here but made a color class in the previous challenge?
// The previous challenge was asking for the color value number which determines what color it is based on the values. 
// This challenge here does not ask anything else other than the color type/name so it would make more sense to make it
// an enum instead of a class that ask for the values of R,G,B to determine what color it is. 