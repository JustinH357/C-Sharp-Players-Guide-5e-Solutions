int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int total = 0;
foreach (int number in array) // variable number holds an item in the array instead of accessing the index
    total += number;

float average = (float)total / array.Length;

Console.WriteLine(average);

int currentSmallest = int.MaxValue; // start with biggest number first
foreach (int number in array)
{
    if (number < currentSmallest)
    {
        currentSmallest = number;
    }
}

Console.WriteLine(currentSmallest);
