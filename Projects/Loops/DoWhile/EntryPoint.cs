using System;

class EntryPoint
{
    static void Main()
    {
        int firstNumber = 4;
        int endNumber = 10;

        //while (firstNumber <= endNumber)
        //{
            //Console.WriteLine(firstNumber);
            //firstNumber++;
        //}

        // Allows at least one iteration regardless of the condition.
        do
        {
            Console.WriteLine(firstNumber);
            firstNumber++;
        }
        while (firstNumber <= endNumber);
    }
}
