using System;

class EntryPoint
{
    static void Main()
    {
        // Arrays are a collection of items of a similar type.

        Random rng = new Random();

        double[] temperatures = new double[5];

        //temperatures[0] = 36.6;  // Celcius
        //temperatures[1] = 37.0;
        //temperatures[2] = 37.2;
        //temperatures[3] = 36.7;
        //temperatures[4] = 36.9;
        //temperatures[5] = 38.0; // Outside the bounds of the array...

        // double[] temperatures = { 36.6, 37.0, 37.2, 36.7, 36.9 };

        double minRange = 35.0;
        double maxRange = 40.0;

        for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = minRange + (maxRange - minRange) * rng.NextDouble();
        }

        // challenge - use a foreach loop to populate the array.
        //foreach (var item in temperatures)
        //{
        //    item = Convert.ToDouble(Console.ReadLine()); // item is read-only...
        //}
    }
}
