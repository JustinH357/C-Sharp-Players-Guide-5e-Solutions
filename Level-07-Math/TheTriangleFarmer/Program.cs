double triangleBase = 0;
double triangleHeight = 0;

Console.WriteLine("What is the base of the triangle?");
triangleBase = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is the height of the triangle?");
triangleHeight = Convert.ToDouble(Console.ReadLine());

double triangleArea = (triangleBase * triangleHeight) / 2;
Console.WriteLine($"Calculating the area of the triangle: {triangleArea}");
