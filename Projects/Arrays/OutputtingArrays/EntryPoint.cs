using System;

class EntryPoint
{
    static void Main()
    {
        //string[] beverages = { "coffee", "cola", "whisky", "milkshake", "water" };

        //Console.WriteLine("The available beverages are: ");
        //for (int i = 0; i < beverages.Length; i++)
        //{
        //    Console.WriteLine($"  {beverages[i]}");
        //}

        //Console.WriteLine(new string('-', 40));
        //Console.WriteLine("The available beverages are: ");
        //foreach (var beverage in beverages)
        //{
        //    Console.WriteLine($"  {beverage}");
        //}

        //Console.WriteLine(new string('-', 40));
        //Console.WriteLine("The available beverages are: ");

        //string joinedArray = string.Join(", ", beverages);
        //Console.WriteLine(joinedArray);

        // challenge - Temperatures - low/mid/high/out of range arrays from one master array of temperatures...
        Random rng = new Random();
        
        int[] temperatures = new int[40];
        int[] lowTemps = new int[temperatures.Length];
        int[] midTemps = new int[temperatures.Length];
        int[] highTemps = new int[temperatures.Length];
        int[] outOfRangeTemps = new int[temperatures.Length];

        // index values for our range arrays...
        int lowTempCnt = 0;
        int midTempCnt = 0;
        int highTempCnt = 0;
        int outOfRangeTempCnt = 0;

        // cursor values for our output...
        int lowCursorPosition = 2;
        int midCursorPosition = 2;
        int highCursorPosition = 2;
        int outOfRangeCursorPosition = 2;

        Console.WriteLine("Range 1 to 10:\n" +
            "\nRange 11 to 20:\n" +
            "\nRange 21 to 30:\n" +
            "\nOut of Range:\n\n");
        for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = rng.Next(0, 40);
        }

        for (int i = 0; i < temperatures.Length; i++)
        {
            if (temperatures[i] > 0 && temperatures[i] <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(lowCursorPosition, 1);
                Console.Write(temperatures[i]);
                Console.ResetColor();
                if (temperatures[i] == 10)
                {
                    lowCursorPosition += 3;
                }
                else
                {
                    lowCursorPosition += 2;
                }
                lowTemps[lowTempCnt] = temperatures[i];
                lowTempCnt++;
            }
            else if (temperatures[i] > 10 && temperatures[i] <= 20)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(midCursorPosition, 3);
                Console.Write(temperatures[i]);
                Console.ResetColor();
                midCursorPosition += 3;
                midTemps[midTempCnt] = temperatures[i];
                midTempCnt++;
            }
            else if (temperatures[i] > 20 && temperatures[i] <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(highCursorPosition, 5);
                Console.Write(temperatures[i]);
                Console.ResetColor();
                highCursorPosition += 3;
                highTemps[highTempCnt] = temperatures[i];
                highTempCnt++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(outOfRangeCursorPosition, 7);
                Console.Write(temperatures[i]);
                Console.ResetColor();
                if (temperatures[i] == 0)
                {
                    outOfRangeCursorPosition += 2;
                }
                else
                {
                    outOfRangeCursorPosition += 3;
                }
                outOfRangeTemps[outOfRangeTempCnt] = temperatures[i];
                outOfRangeTempCnt++;
            }

        }
        Console.SetCursorPosition(0, 8);
    }
}
