using System;

class EntryPoint
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7 };

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        // used only on collections - arrays/lists
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}
