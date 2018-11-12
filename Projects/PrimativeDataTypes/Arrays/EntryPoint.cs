using System;

class EntryPoint
{
    static void Main()
    {
        // Arrays are collections of data - for a given data type
        int[] numbers = { 5, 6, 7, 8, 3, 4, 2, 1 };

        Console.WriteLine(numbers);
        Console.WriteLine(numbers[3]);
        Console.WriteLine(numbers[7]);

        int[] moreNumbers = new int[5]; // this creates an array of ints that has 5 values - initialized to zero for each index
        Console.WriteLine(moreNumbers);
        Console.WriteLine(moreNumbers[3]);
        Console.WriteLine(moreNumbers[2]);

        moreNumbers[2] = 7;
        Console.WriteLine(moreNumbers[2]);

        // challenge - create an array of strings that stores 5 different fruits - use both methods
        string[] fruit = { "Orange", "Apple", "Banana", "Peach", "Watermelon" };

        string[] moreFruit = new string[5];
        moreFruit[0] = "Orange";
        moreFruit[1] = "Apple";
        moreFruit[2] = "Banana";
        moreFruit[3] = "Peach";
        moreFruit[4] = "Watermelon";

        Console.WriteLine(fruit[2]);
        Console.WriteLine(fruit[2][0]);

        fruit[2] = "Lemon";
        Console.WriteLine(fruit[2]);
    }
}
