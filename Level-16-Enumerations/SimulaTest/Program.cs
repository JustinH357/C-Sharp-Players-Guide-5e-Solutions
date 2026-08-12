Chest state = Chest.Locked;

// this works as intended somehow like how i envisioned it
while (true)
{
    ChestState(state);
    string answer = Console.ReadLine();

    state = ChestChoice(answer, state);
}

// knowing that i didnt need to create a method to display the state, i could just leave the if loop
// in the while loop
Chest ChestChoice(string answer, Chest state)
{
    // can do if chest is locked, user must unlock it first else give warning
    if (answer == "unlock" && state == Chest.Locked)
    {
        return Chest.Unlocked;
    }
    else if (answer == "open" && state == Chest.Unlocked)
    {
        return Chest.Open;
    }
    else if (answer == "close" && state == Chest.Open)
    {
        return Chest.Closed;
    }

    return Chest.Locked;
}


// this method just finds the state then displays the state and ask so I could of just do
// cw($"the chest is {state}. What do you want to do?") inside the while loop
void ChestState(Chest state)
{
    // want to print out the state of the chest and ask user what to do
    // may want to do an else instead and leave one of the state not using "else if"
    if (state == Chest.Locked)
    {
        Console.Write("The chest is locked. What do you want to do? ");
    }
    else if (state == Chest.Open)
    {
        Console.Write("The chest is open. What do you want to do? ");
    }
    else if (state == Chest.Closed)
    {
        Console.Write("The chest is unlocked. What do you want to do? ");
    }
    else if (state == Chest.Unlocked)
    {
        Console.Write("The chest is unlocked. What do you want to do? ");
    }
}

enum Chest { Open, Closed, Locked, Unlocked }