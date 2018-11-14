using System;

class EntryPoint
{
    static void Main()
    {
        // challenge - check number if even or odd
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("Number is even.");
        } else
        {
            Console.WriteLine("Number is odd.");
        }

        string numEvenOdd = num % 2 == 0 ? "even" : "odd";
        Console.WriteLine($"Number is {numEvenOdd}.");

        // Challenge:

        if ((num % 2 == 0) && (num % 3 == 0) && (num % 4 == 0) )
        {
            Console.WriteLine($"The number {num} is divisible by 2, 3 and 4!");
        }
        else
        {
            Console.WriteLine($"The number {num} is NOT divisible by 2, 3 and 4!");
        }

        // Challenge
        string numStr = num.ToString();
        if (numStr.Length >= 3)
        {
            char thirdDigit = numStr[numStr.Length - 3];

            if (thirdDigit == '3')
            {
                Console.WriteLine($"The third digit of number {num} is 3!");
            }
            else
            {
                Console.WriteLine($"The third digit of number {num} is NOT 3!");
            }
        }
        else
        {
            Console.WriteLine($"The number {num} is too small to find a third digit!");
        }


        // challenge
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);

    }
}
