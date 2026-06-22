int userNumber;

Console.Write("User 1, enter a number between 0 and 100: ");

// only need to run one time, and goes again if user doesn't meet the prompt/condition
do
{
    userNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Number must between 0-100!");
    Console.Write("Enter a number again: ");
}
while (userNumber < 0 || userNumber > 100); // repeats again if user doesn't choose number between 0-100

Console.Clear();

Console.WriteLine("User 2, guess the number.");

while (true)
{
    int userGuess = Convert.ToInt32(Console.ReadLine());
    //int userGuess = AskForNumber("What is you next guess"); // issue is that this shows up for the first number guess

    if (userGuess == userNumber)
        break;
    else if (userGuess > userNumber)
        Console.WriteLine($"{userGuess} is too high.");
    else
        Console.WriteLine($"{userGuess} is too low.");

    //Console.WriteLine("What is your next guess?");
}

Console.WriteLine("Nice! You guessed it right!");
        }