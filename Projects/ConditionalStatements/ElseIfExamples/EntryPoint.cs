using System;

class EntryPoint
{
    static void Main()
    {
        // challenge
        int x, y;
        int radius = 4;

        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        Console.WriteLine($"The distance is {distance}");

        if (distance > radius)
        {
            Console.WriteLine($"The point ({x}, {y}) is outside the circle!");
        }
        else if (distance < radius)
        {
            Console.WriteLine($"The point ({x}, {y}) is inside the circle!");
        }
        else
        {
            Console.WriteLine($"The point ({x}, {y}) is on the circle's edge!");
        }

        // challenge
        // input in meters
        // ask the user to what conversion to use - cm, mm, km, micrometers, decimeters

        Console.WriteLine("Please enter a number of meters: ");
        int meters = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Now, what do you want to convert to?");
        Console.WriteLine("1 - Micrometers");
        Console.WriteLine("2 - Millimeters");
        Console.WriteLine("3 - Centimeters");
        Console.WriteLine("4 - Decimeters");
        Console.WriteLine("5 - Kilometers");
        Console.WriteLine("Please enter a number, 1-5");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine($"The number of micrometers is {meters * Math.Pow(10, 6)}");
        }
        else if (choice == 2)
        {
            Console.WriteLine($"The number of millimeters is {meters * 1000}");
        }
        else if (choice == 3)
        {
            Console.WriteLine($"The number of centimeters is {meters * 100}");
        }
        else if (choice == 4)
        {
            Console.WriteLine($"The number of decimeters is {meters * 10}");
        }
        else if (choice == 5)
        {
            Console.WriteLine($"The number of kilometers is {(double)meters / 1000}");
        }
        else
        {
            Console.WriteLine("Invalid Choice!");
        }
    }
}
