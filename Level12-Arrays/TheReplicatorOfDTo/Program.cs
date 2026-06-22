int[] array = new int[5];
int[] secondArray = new int[5];
int indexCount = 0;

Console.WriteLine("Pick 5 numbers");

while (indexCount < array.Length)
{
    Console.Write("Type your number: ");

    int userNumber = Convert.ToInt32(Console.ReadLine());

    array[indexCount] = userNumber;
    indexCount++;
}

Console.Clear();

// not sure if its better practice to make a new loop that displays both list
for (int index = 0; index < array.Length; index++)
{
    secondArray[index] = array[index];

    Console.WriteLine($"Number for Index {index + 1}");
    Console.WriteLine($"First array: {array[index]}");
    Console.WriteLine($"Second array: {secondArray[index]}");
    Console.WriteLine("");
}
