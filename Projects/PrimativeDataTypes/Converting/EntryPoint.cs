using System;

class EntryPoint
{
    static void Main()
    {
        int number = 5;
        string word = "5";
        char x = 'x';
        float pi = 3.14f;

        // Type casting - only works on compatible data types (numbers for example)
        float integer = number; // no loss of information, so this will work
        int floating = (int)pi; // this doesn't work because of loss of information... so we have to typecast using the () operator

        Console.WriteLine(integer);
        Console.WriteLine(floating);

        // Convert object functions - converting a null value will return zero
        int stringedInteger = Convert.ToInt32(word);
        Console.WriteLine(stringedInteger);

        // Cannot parse null values - will throw an exception
        int parsedString = int.Parse(word);
        Console.WriteLine(parsedString);
    }
}
