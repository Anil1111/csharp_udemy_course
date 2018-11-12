using System;

class EntryPoint
{
    static void Main()
    {
        float someFloatNumber = 3.1455234225f;
        // float requires the 'f' suffix (32 bit number)
        // only allows for precision of 7 digits.

        System.Console.WriteLine(someFloatNumber);

        float someBigFloatNumber = 64534636345235.43f;
        System.Console.WriteLine(someBigFloatNumber);
        System.Console.WriteLine(someBigFloatNumber.ToString("f"));
        // you can see that the precision of the information becomes zeroes after the 7th digit!

        Console.WriteLine();
        float radius = 5f;
        float areaOfCircle = (float)Math.PI * radius * radius;
        Console.WriteLine(areaOfCircle);

        float fMax = float.MaxValue;
        float fMin = float.MinValue;

        Console.WriteLine(fMax.ToString("f"));
        Console.WriteLine(fMin.ToString("f"));
        // Much larger than an integer or long!  but precision is lost!

        double doubleMax = double.MaxValue;
        double doubleMin = double.MinValue;
        // precision is up to 15 digits  (64 bit number)

        Console.WriteLine(doubleMax);
        Console.WriteLine(doubleMin);

        Console.WriteLine(doubleMax.ToString("f"));
        Console.WriteLine(doubleMin.ToString("f"));

        decimal decimalMax = decimal.MaxValue;
        decimal decimalMin = decimal.MinValue;
        // precision up to 28 digits (128 bit number)

        Console.WriteLine(decimalMax);
        Console.WriteLine(decimalMin);

        Console.WriteLine(decimalMax.ToString("f"));
        Console.WriteLine(decimalMin.ToString("f"));

    }
}
