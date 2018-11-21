using System;

class EntryPoint
{
    static void Main()
    {
        string[] fruits = { "orange", "lemon", "strawberry", "apple", "banana" };

        //Array.Reverse(fruits);  // overwrites the original array...

        //foreach (var fruit in fruits)
        //{
        //    Console.WriteLine(fruit);
        //}

        MyReverse(fruits, 1, 4);

        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

    }

    // challenge
    static void MyReverse(string[] a1, int startIndex = 0, int endIndex = 0)
    {
        if (endIndex == 0)
        {
            endIndex = a1.Length - 1;
        }

        for (int i = 0; i < a1.Length; i++)
        {
            if (i >= startIndex && i <= endIndex)
            {
                // swap the values...
                string temp = a1[i];
                a1[i] = a1[endIndex];
                a1[endIndex] = temp;
                endIndex--;
            }
        }

    }
}
