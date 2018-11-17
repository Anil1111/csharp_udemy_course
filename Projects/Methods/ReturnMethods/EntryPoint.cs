using System;

class EntryPoint
{
    static void Main()
    {
        Console.WriteLine(Addition(1, 1));
        int resultFromAddition = Addition(Addition(1, 2), Addition(4, 5));
        Console.WriteLine(resultFromAddition);

        int[] numVals = { 1, 4, 3, 1, 2, 6, 5 };
        int[] sortedVals = sortNumbers(numVals);

        foreach (var item in sortedVals)
        {
            Console.WriteLine(item);
        }
    }

    static int Addition(int firstNumber, int secondNumber)
    {
        int result = firstNumber + secondNumber;

        return result;
    }

    static int[] sortNumbers(int[] numbers)
    {
        int temp = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }

        return numbers;
    }
}

