int estatePerPoint = 1;
int provincesPerPoint = 6;
int duchiesPerPoint = 3;

Console.WriteLine("\tDetermining total current holdings");

Console.WriteLine("How many estate do you have?");
string estateAnswer = Console.ReadLine();
Console.WriteLine("How many duchy do you have?");
string duchiesAnswer = Console.ReadLine();
Console.WriteLine("How many provinces do you have?");
string provincesAnswer = Console.ReadLine();

int estateTotalPoints = Convert.ToInt32(estateAnswer) * estatePerPoint;
Console.WriteLine($"You have {estateAnswer} estate. Adding up the points....");
Console.WriteLine($"total estate points: {estateTotalPoints}");

int duchiesTotalPoints = Convert.ToInt32(duchiesAnswer) * duchiesPerPoint;
Console.WriteLine($"You have {duchiesAnswer} duchies. Adding up the points....");
Console.WriteLine($"total estate points: {duchiesTotalPoints}");

int provincesTotalPoints = Convert.ToInt32(provincesAnswer) * provincesPerPoint;
Console.WriteLine($"You have {provincesAnswer} provinces. Adding up the points....");
Console.WriteLine($"total estate points: {provincesTotalPoints}");

int totalHoldings = estateTotalPoints + duchiesTotalPoints + provincesTotalPoints;
Console.WriteLine($"Total Holdings: {totalHoldings}");
