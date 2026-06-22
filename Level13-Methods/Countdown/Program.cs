CountDownFromTen(10);

int CountDownFromTen(int number)
{
    Console.WriteLine(number); // print first to get all numbers

    // could do if 0 just return that way writeline gets all the numbers from 10-1
    if (number == 1) return 1; // stops the recursion

    // 10,9,8,7,6,5,4,3,2,1
    return CountDownFromTen(number - 1);
}