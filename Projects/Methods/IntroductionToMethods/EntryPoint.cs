using System;

class EntryPoint
{
    static void Main()
    {
        Console.WriteLine("Before the methods...");
        PrintingNames(); // Calling the new method...
        PrintingNames();
        Console.WriteLine("In between the methods");  // Proving the flow of code that when a method is called, that execution jumps into the method then back to after the method was called.
        PrintingNames();
        PrintingNames();
        Console.WriteLine("After the methods...");
    }

    // New Method defined... Which should do only one thing!
    static void PrintingNames()
    {
        Console.Write("My name is ");
        Console.Write("Jerry Hampton and I'm ");
        Console.Write("learning C#.\n");
    }
}
