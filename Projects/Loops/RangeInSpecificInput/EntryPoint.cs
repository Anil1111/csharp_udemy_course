using System;

class EntryPoint
{
    static void Main()
    {
        // challenge
        Console.Write("Please input a number between 20 and 30: ");
        int num = Convert.ToInt32(Console.ReadLine());

        while (num < 20 || num > 30)
        {
            Console.Write("Given number is outside of the range! Please input a number between 20 and 30: ");
            num = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"Congratulations! You entered a number, {num}, that is inside the range!");


        // challenge

    }
}
