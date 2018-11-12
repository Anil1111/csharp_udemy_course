using System;

class EntryPoint
{
    static void Main()
    {
        // string separator = "---------------------";
        string separator = new string('-', 40); // this is an easier way to create a string of repeated characters...
        string fruitJuice = "Strawberry Juice";

        Console.WriteLine(fruitJuice.Contains("f")); // cannot find this...
        Console.WriteLine(fruitJuice.Contains("r"));
        Console.WriteLine(fruitJuice.Contains("R")); // case sensitive! - this isn't found...
        Console.WriteLine(separator);

        Console.WriteLine(fruitJuice.IndexOf("f"));
        Console.WriteLine(fruitJuice.IndexOf("r")); // first index of this character in the string...
        Console.WriteLine(fruitJuice.LastIndexOf("r"));
        Console.WriteLine(separator);

        Console.WriteLine(fruitJuice.Contains("berry"));
        Console.WriteLine(fruitJuice.IndexOf("berry"));
        Console.WriteLine(fruitJuice.LastIndexOf("berry"));
        Console.WriteLine(separator);

        // challenge - find 'straw' using ToLower and Contains on the same line
        Console.WriteLine(fruitJuice.ToLower().Contains("straw"));
        Console.WriteLine(separator);

    }
}
