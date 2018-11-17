using System;

class EntryPoint
{
    static void Main()
    {
        //Console.WriteLine();  // returns void - no return value...
        PrintingNames("Jerry", "Hampton");  // We can pass in parameters to the method to be used by the method...
        PrintingNames("Bob", "Marley");

        ConsolePrintColor("This is a test text", ConsoleColor.DarkBlue);
    }

    // Void means that the method returns nothing (void!).
    static void  PrintingNames(string firstName, string lastName)
    {
        //string firstName = "Jerry";  // Methods can have local variables to the method...
        //string lastName = "Hampton";

        Console.WriteLine($"My name is {firstName} {lastName}");
    }

    // challenge - 2 arguments to the method - string and color
    static void ConsolePrintColor(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }
}
