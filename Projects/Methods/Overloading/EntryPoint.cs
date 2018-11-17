using System;

class EntryPoint
{
    static void Main()
    {
        PrintNames("Jerry", "Hampton");
        PrintNames("Jerry", "Thomas", "Hampton");
        PrintNames("Jerry", "Hampton", ConsoleColor.DarkGreen);

        Console.WriteLine(Sum(5, 5, 5, 5));

        // challenge - Area Method
        Console.WriteLine(Area(4));
        Console.WriteLine(Area(4, 7));
        Console.WriteLine(Area(1, 1, 1));
    }

    static void PrintNames(string firstName, string lastName)
    {
        Console.WriteLine($"My name is {firstName} {lastName}.");
    }

    static void PrintNames(string firstName, string middleName, string lastName)
    {
        Console.WriteLine($"My name is {firstName} {middleName} {lastName}.");
    }

    static void PrintNames(string firstName, string lastName, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"My name is {firstName} {lastName}.");
        Console.ResetColor();
    }

    static int Sum(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    static int Sum(int firstNumber, int secondNumber, int thirdNumber)
    {
        return firstNumber + secondNumber + thirdNumber;
    }

    static int Sum(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber)
    {
        return firstNumber + secondNumber + thirdNumber + fourthNumber;
    }

    static double Area(double side)
    {
        return side * side;
    }

    static double Area(double length, double width)
    {
        return length * width;
    }

    static double Area(double a, double b, double c)
    {
        double s = (a + b + c) / 2;

        return Math.Sqrt((s * ((s - a) * (s - b) * (s - c))));
    }
}

