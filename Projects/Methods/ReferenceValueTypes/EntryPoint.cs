using System;

class EntryPoint
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        int[] secondArray = array;  // secondArray is pointing back (referencing) to the array - does not actually hold these values

        array[2] = 10;

        Console.WriteLine(secondArray[2]);

        Console.WriteLine(array[0]);
        ModifyArray(array); // modify the array below...
        Console.WriteLine(array[0]);

        int number = 10;
        int secondNumber = number; // primitive types actually create a copy of the value - not the address/reference like the array does.

        number = 15;
        Console.WriteLine(secondNumber);
    }

    // proof that arrays use references... we can modify an array that's passed into a method without returning anything
    static void ModifyArray(int[] array)
    {
        array[0]++;
    }
}
