// NW - x<0 & y>0 | N - x=0 & y>0 | NE - x>0 & y>0
// W - x<0 & y=0  | ! - x=0 & y=0 | E - x>0 & y=0
// SW - x<0 & y<0 | S - x=0 & y<0 | SE - x>0 & y<0

Console.WriteLine("Give an x value:");
int xCordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Give a y value:");
int yCordinate = Convert.ToInt32(Console.ReadLine());

if (xCordinate < 0 && yCordinate > 0)
{
    // NW - x<0 & y>0
    Console.WriteLine("The enemies are northwest from here!");
}
else if (xCordinate == 0 && yCordinate > 0)
{
    //  N - x=0 & y>0
    Console.WriteLine("The enemies are north from here!");
}
else if (xCordinate > 0 && yCordinate > 0)
{
    // NE - x>0 & y>0
    Console.WriteLine("The enemies are northeast from here!");
}
else if (xCordinate < 0 && yCordinate == 0)
{
    // W - x<0 & y=0
    Console.WriteLine("The enemies are west from here!");
}
else if (xCordinate > 0 && yCordinate == 0)
{
    // E - x>0 & y=0
    Console.WriteLine("The enemies are east from here!");
}
else if (xCordinate < 0 && yCordinate < 0)
{
    // SW - x<0 & y<0
    Console.WriteLine("The enemies are southwest from here!");
}
else if (xCordinate == 0 && yCordinate < 0)
{
    // S - x=0 & y<0
    Console.WriteLine("The enemies are south from here!");
}
else if (xCordinate > 0 && yCordinate < 0)
{
    // SE - x>0 & y<0
    Console.WriteLine("The enemies are southeast from here!");
}
else
{
    // ! - x and y = 0 
    Console.WriteLine("The enemies are here!");
}