using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        int someInteger = 7;
        // 2^32 is max value for an int type.

        int intMax = int.MaxValue;
        int intMin = int.MinValue;


        System.Console.WriteLine("Max Value = " + intMax);
        System.Console.WriteLine("Min Value = " + intMin);

        uint someUInteger = 5;  
        // Unsigned Integer -> uint - can only be positive.

        uint minUInt = uint.MinValue;
        uint maxUInt = uint.MaxValue;

        System.Console.WriteLine(minUInt);
        System.Console.WriteLine(maxUInt);

        System.Console.WriteLine(Math.Pow(2, 32));

        byte someByteNumber = 255;
        // 2^8 values...

        byte minByte = byte.MinValue;
        byte maxByte = byte.MaxValue;

        Console.WriteLine(minByte);
        Console.WriteLine(maxByte);

        sbyte minSByte = sbyte.MinValue;
        sbyte maxSByte = sbyte.MaxValue;

        Console.WriteLine(minSByte);
        Console.WriteLine(maxSByte);

        long minLong = long.MinValue;
        long maxLong = long.MaxValue;
        // 2^64 values

        Console.WriteLine(minLong);
        Console.WriteLine(maxLong);

        ulong minULong = ulong.MinValue;
        ulong maxULong = ulong.MaxValue;

        Console.WriteLine(minULong);
        Console.WriteLine(maxULong);

    }
}
