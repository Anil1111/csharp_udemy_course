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
        int area, parimeter;
        CalcAreaAndParimeter(4, 6, out area, out parimeter);
        Console.WriteLine($"Area = {area}: Parimeter = {parimeter}");
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
    static void CalcAreaAndParimeter(int length, int width, out int area, out int parimeter)
    {
        area = length * width;
        parimeter = 2 * length + 2 * width;
    }
}
