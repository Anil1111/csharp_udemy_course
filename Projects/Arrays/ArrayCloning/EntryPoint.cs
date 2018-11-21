using System;

class EntryPoint
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        //int[] secondArray = (int[])array.Clone();  // creates new values for the 2nd array...
        int[] secondArray = new int[array.Length];

        Array.Copy(array, secondArray, array.Length);  // more versatile...

        array[2] = 10;

        Console.WriteLine(array[2]);
        Console.WriteLine(secondArray[2]);

        int[] testArr = { 1, 2, 3, 4 };
        int[] secTestArr = new int[testArr.Length];

        IntArrayCopy(testArr, secTestArr, testArr.Length);
        for (int i = 0; i < testArr.Length; i++)
        {
            Console.WriteLine($"source = {testArr[i]}");
            Console.WriteLine($"copy = {secTestArr[i]}");
        }
    }

    // challenge
    static void IntArrayCopy(int[] a1, int[] a2, int numValsToCopy)
    {
        if (a1.Length == 0 || numValsToCopy > a1.Length)
        {
            throw new Exception("Invalid Array Length");
        }

        for (int i = 0; i < a1.Length; i++)
        {
            if (i == numValsToCopy)
            {
                break;
            }
            else
            {
                a2[i] = a1[i];
            }
        }
    }
}
