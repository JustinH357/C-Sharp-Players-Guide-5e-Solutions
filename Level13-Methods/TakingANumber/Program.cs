//DominionOfKing program 
int estateAnswer = AskForNumber("How many duchy do you have?");
Console.WriteLine($"Total estate points are {estateAnswer * 1}");

//The Prototype program
int userNumber = AskForNumberInRang("User 1, enter a number between 0 and 100: ", 0, 100);
Console.WriteLine($"Your number is {userNumber}");

int AskForNumber(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());

    return number;
}

int AskForNumberInRang(string text, int min, int max)
{
    Console.WriteLine(text);

    int userNumber;
    do
    {
        userNumber = Convert.ToInt32(Console.ReadLine());
    }
    while (userNumber < min || userNumber > max); // repeat if not between 0-100

    // return number when the number is actually between 0-100
    return userNumber;
}