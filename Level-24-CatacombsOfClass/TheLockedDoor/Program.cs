State currentState = State.Open;

// can do a "do while" loop and repeat if not number
Console.WriteLine("Please type in a code for the door to unlock:");
int currentCode = Convert.ToInt32(Console.ReadLine());

Console.Clear();

while (true)
{
    Door door = new Door(currentCode); 

    if (currentState == State.Unlock)
        Console.WriteLine("The is now unlocked. What do you want to do?");
    else
        Console.WriteLine($"The door is {currentState}. What do you want to do?");

    string answer = Console.ReadLine();
    currentState = door.DoorState(answer, currentState);
    
    if (currentState == State.Lock)
    {
        Console.WriteLine("Door is now locked.");
        Console.WriteLine("Type in the code to open:");
        int code = Convert.ToInt32(Console.ReadLine());

        if (code == currentCode)
        {
            currentState = State.Unlock;

            Console.WriteLine("Set new code for the door");
            int newCode = Convert.ToInt32(Console.ReadLine());
            currentCode = newCode;

            door.ChangeCode(currentCode);
        }
    }
}


class Door
{
    // could make properties for the different states and leave the code since that is the one that is being saved? 
    // author had a proptery for the state with { get; private set }. It is probably private because we don't want it 
    // to be access by mistake. 
    public int _code { get; }
    //public State _state { get; }
    public Door(int code) => _code = code;

    public State DoorState(string answer, State state)
    {
        // can do if chest is locked, user must unlock it first else give warning
        if (answer == "unlock" && state == State.Lock)
        {
            return State.Unlock;
        }
        else if (answer == "open" && state == State.Unlock)
        {
            return State.Open;
        }
        else if (answer == "close" && state == State.Open)
        {
            return State.Close;
        }

        return State.Lock;
    }

    public Door ChangeCode(int newCode) => new Door(newCode);
}

enum State { Open, Close, Lock , Unlock }

// My Thoughts:
// Works like the challenge is stated. Think I can refactor or clean this better.