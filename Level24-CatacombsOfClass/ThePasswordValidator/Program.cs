while (true)
{
    PasswordValidator passwordValidator;
    Console.WriteLine($"Type in your password:");
    string password = Console.ReadLine();

    passwordValidator = new PasswordValidator(password);

    if (passwordValidator.IsValidPassword()) break; // if true stop else continue loop
}

Console.WriteLine("Password set.");

class PasswordValidator
{
    // public properties PascalCase, private camelCase or _camelCase.
    // noticed author done it like this for the past challenges and should keep in mind to do.  
    public string Password { get; }
    private int _upperCaseCount;
    private int _lowerCaseCount;
    private int _digitCount;
    private bool _isCorrectLength;

    public PasswordValidator(string password) => Password = password;

    public bool IsValidPassword()
    {
        if (Password.Length <13 && Password.Length >= 6) _isCorrectLength = true;

        foreach (char character in Password)
        {
            if (character == '&' || character == 'T') return false;

            // was struggling but re-read the challenge objectives again and I need to check if either of these conditions is fulfilled at least once 
            // meaning I just need to count each conditions if they are true
            // I could just put the private properties within this method instead of the class since I don't really need them outside of this.
            if (char.IsLower(character)) _lowerCaseCount++;
            if (char.IsUpper(character)) _upperCaseCount++;
            if (char.IsDigit(character)) _digitCount++;
        }

        if (_upperCaseCount >= 1 && _lowerCaseCount >= 1 && _digitCount >= 1 && _isCorrectLength) return true; // if all conditions are true

        return false;
    }
}