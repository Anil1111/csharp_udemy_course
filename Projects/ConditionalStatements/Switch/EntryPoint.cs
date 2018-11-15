using System;

class EntryPoint
{
    static void Main()
    {

        // challenge... basically what was asked for...
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

        switch (choice)
        {
            case 1:
                Console.WriteLine($"The number of micrometers is {meters * Math.Pow(10, 6)}");
                break;
            case 2:
                Console.WriteLine($"The number of millimeters is {meters * 1000}");
                break;
            case 3:
                Console.WriteLine($"The number of centimeters is {meters * 100}");
                break;
            case 4:
                Console.WriteLine($"The number of decimeters is {meters * 10}");
                break;
            case 5:
                Console.WriteLine($"The number of kilometers is {(double)meters / 1000}");
                break;
            default:
                Console.WriteLine("Invalid Choice!");
                break;
        }
    }
}
