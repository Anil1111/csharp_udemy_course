using System;

class EntryPoint
{
    static void Main()
    {
        // ref keyword will allow you to pass any variable by reference...

        int number = 0;
        Console.WriteLine(number);
        IncreaseByOne(ref number);
        Console.WriteLine(number);

        double x = 10;
        double y = 15;

        CorrectTheCoordinates(ref x, ref y);

        // out keyword - allows multiple returns, however, the assignment must be done inside the method
        int area, perimeter;
        CalcAreaAndPerimeter(4, 6, out area, out perimeter);
        Console.WriteLine($"Area = {area}: Perimeter = {perimeter}");
    }

    static void IncreaseByOne(ref int number)
    {
        number++;
    }

    // makes a function flexible if you need to modify multiple items in a method...
    static void CorrectTheCoordinates(ref double x, ref double y)
    {
        x *= 1.1;
        y *= 1.1;
    }

    //challenge
    static void CalcAreaAndPerimeter(int length, int width, out int area, out int perimeter)
    {
        area = length * width;
        perimeter = 2 * length + 2 * width;
    }
}
