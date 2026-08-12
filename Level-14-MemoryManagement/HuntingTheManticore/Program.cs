int round = 1;
int cityHp = 15;
int manticoreHp = 10;

// range from 0-100
int distance = SetManticoreDistance("Player 1, how far away from city do you want to station the manticore? ", 0,
    100);

Console.Clear();

Console.WriteLine("Player 2, it is your turn.");

// could of done while loop checking if both city n manitcore hp is greater than zero
// when one of the other hp is lower than zero which is false, the while loop will stop
// when the loop breaks, you can do a check to see if city hp is > 0 then you won or check manticore instead
while (true)
{
    // instead of making two separate "round" displaying text and bool just return the number 
    // point of checking the rounds is for the damage per round
    // could create method to display the status for each round
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Status: Round {round} City {cityHp}/15 Manticore {manticoreHp}/10");
    Console.WriteLine(DisplayCannonDamagePerRound(round));
    Console.Write("Enter cannon range: ");
    int range = Convert.ToInt32(Console.ReadLine());

    // no need to do if, if else, else for here since the manticore only takes dmg when the range is correct
    // just check if range == distance then manticore takes dmg
    // every round cityHp is always losing hp until you beat the manticore
    // can do a check to -1 cityHp if manticore still alive
    // could do cityhp-- which is the same as cityHp -= 1;
    Console.ForegroundColor = ConsoleColor.Yellow;
    if (range > distance)
    {
        Console.WriteLine("Cannon OVERSHOT the target");
        cityHp -= 1;
    }
    else if (range < distance)
    {
        Console.WriteLine("Cannon FELL SHORT to the target");
        cityHp -= 1;
    }
    else
    {
        Console.WriteLine("DIRECT HIT!");

        if (IsMultipleOfThreeOrFive(round)) manticoreHp -= 3;
        else if (IsMultipleOfBothThreeOfFive(round)) manticoreHp -= 10;
        else manticoreHp -= 1;

        cityHp -= 1;
    }

    round++;

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("----------------------------------------------------------------"); //spacing

    if (HealthIsBelowZero(cityHp, manticoreHp)) break;
}

int SetManticoreDistance(string text, int min, int max)
{
    int distance;
    do
    {
        Console.Write(text);
        distance = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Distance must be between {min} and {max}!"); // repeat if distance is not between 0-100
    }
    while (distance < min || distance > max);

    return distance;
}

string DisplayCannonDamagePerRound(int round)
{
    if (round % 3 == 0 || round % 5 == 0)
    {
        return "Cannon deals 3 damage this round";
    }

    return "Cannon deals 1 damage this round";
}

bool IsMultipleOfBothThreeOfFive(int round)
{
    if (round % 3 == 0 && round % 5 == 0)
    {
        return true;
    }

    return false;
}

bool IsMultipleOfThreeOrFive(int round)
{
    if (round % 3 == 0 || round % 5 == 0)
    {
        return true;
    }

    return false;
}

bool HealthIsBelowZero(int cityHp, int manticoreHp)
{
    if (cityHp <= 0)
    {
        Console.WriteLine("You failed to defend against the manticore.");
        return true;
    }

    if (manticoreHp <= 0)
    {
        Console.WriteLine("You won against the manticore.");
        return true;
    }

    return false;
}