using System;

// > Greater Than
// < Less Than
// == Equal To
// >= Greater Than or Equal To
// <= Less Than or Equal To
// != Not Equal To (different)

class EntryPoint
{
    static void Main()
    {
        int firstNumber = 5;
        int secondNumber = 10;

        Console.WriteLine(firstNumber > secondNumber);
        Console.WriteLine(firstNumber < secondNumber);
        Console.WriteLine(firstNumber == secondNumber);
        Console.WriteLine(firstNumber >= secondNumber);
        Console.WriteLine(firstNumber <= secondNumber);
        Console.WriteLine(firstNumber != secondNumber);

        bool isTheFirstNumberLessThanSecondNumber = firstNumber < secondNumber;
        Console.WriteLine(isTheFirstNumberLessThanSecondNumber);

        // you can compare strings...
        Console.WriteLine("Jerry" == "jerry");

        // challenge
        Console.WriteLine("Jerry".Length >= "jerry".Length);
    }
}
