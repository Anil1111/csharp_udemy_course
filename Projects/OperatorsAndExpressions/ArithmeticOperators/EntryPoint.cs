using System;

class EntryPoint
{
    static void Main()
    {
        int firstNumber = 5;
        int secondNumber = 10;

        int addition = firstNumber + secondNumber;
        Console.WriteLine(addition);

        int subtraction = firstNumber - secondNumber;
        Console.WriteLine(subtraction);

        int multiplication = firstNumber * secondNumber;
        Console.WriteLine(multiplication);

        int division = firstNumber / secondNumber;
        double doubleDivision = (double)firstNumber / (double)secondNumber;
        Console.WriteLine(division);
        Console.WriteLine(doubleDivision);

        int thirdNumber = 15;

        int equation = firstNumber * (secondNumber - thirdNumber); // fix order of operations with the parens
        Console.WriteLine(equation);

        // Challenge
        double eq = ((3 / 7) + Math.Pow(5, 2)) / (3 + (4 / 3));
        Console.WriteLine(eq);

        // ++, --
        Console.WriteLine(firstNumber);
        firstNumber++; // increment the number by 1
        Console.WriteLine(firstNumber);
        firstNumber--; // decrement the number by 1
        Console.WriteLine(firstNumber);

        // % - modulo operator - remainder
        int remainder = thirdNumber % secondNumber;
        Console.WriteLine(remainder);
    }
}
