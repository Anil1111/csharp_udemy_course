using System;

class EntryPoint
{
    static void Main()
    {
        int number = 1;

        while (number <= 10)
        {
            Console.WriteLine(number);
            number++;
        }

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // challenge
        int[] numbers = { 2, 4, 3, 1, 6, 5, 7, 10, 9, 8};

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
