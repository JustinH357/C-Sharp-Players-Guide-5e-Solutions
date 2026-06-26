State currentState = State.Open;

// can do a "do while" loop and repeat if not number
Console.WriteLine("Please type in a code for the door to unlock:");
int currentCode = Convert.ToInt32(Console.ReadLine());

Console.Clear();

while (true)
{
    Door door = new Door(currentCode); // keeps _code up to date with the passcode changes

    Console.WriteLine($"Track door code: {door._code}"); // check if door code is being changes correctly

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
    // should I not make properties for the different states and leave the code since that is the one that is being saved? 
    public int _code { get; }
    public State _state { get; }
    //public State _open { get; }
    //public State _close { get; }
    //public State _lock { get; }
    //public State _unlock { get; }

    // lock seems to be a keyword within VS so made it "Lock" instead
    // could check for state and passcode and update it within the while loop
    public Door(int code)
    {
        _code = code;
        //_open = open;
        //_close = close;
        //_lock = Lock;
        //_unlock = unlock;
    }

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

// not sure if I leave it as enum since I could do String open, etc property
enum State { Open, Close, Lock , Unlock }

// My Thoughts:
// Works like the challenge is stated. Think I can refactor or clean this better.