using System;

class EntryPoint
{
    static void Main()
    {
        Console.WriteLine(Sum(5, 6, 7, 3, 2, 1));

        string firstName = "Jerry";
        string lastName = "Hampton";
        MyWriteLine("[0] [1]", firstName, lastName);
    }

    // params key word allows you to utilize variable number of arguments to the method... but all arguments must be of the same type - hence the array of ints below...
    static int Sum(params int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    // challenge - create own variable argument version of console.writeline... was confusing what was being asked, so I waited and copied what the instructor did..
    static void MyWriteLine(string text, params string[] variables)
    {
        string newText = string.Empty;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].ToString() == "[")
            {
                newText += variables[int.Parse(text[i + 1].ToString())];
                i += 2;
            }
            else
            {
                newText += text[i];                    
            }
        }

        Console.WriteLine(newText);
    }
}
