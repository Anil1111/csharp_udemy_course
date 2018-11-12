using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        Console.Write("I am learning ");  // Keeps the cursor on the same line...
        Console.Write("from the ");
        Console.Write("best C# course.\n");  // '\n' is a 'newline' character to move the cursor to the next line

        Console.WriteLine("I am learning ");  // Puts the cursor on the next line...
        Console.WriteLine("from the ");
        Console.WriteLine("best C# course.");

        Console.WriteLine();
        // Challenge - create a menu only using Console.Write
        Console.Write("1. Add new item\n2. Edit an item\n3. Remove an item\n4. Exit\nYour choice:\n");

        string separator = new string('-', 40);
        Console.WriteLine(separator);
        Console.WriteLine();
        // Escaping special characters
        string exeFile = "Word.exe";
        //string pathToExe = "\"C:\\Program Files\\Microsoft Word\\\"";  
        // '\' is used to escape special characters, so here we're escaping the '\' so that one '\' displayed...
        // also, we're escaping the '"' character so that we surround the string in quotes when it's printed to the console.

        string pathToExe = @"""C:\Program Files\Microsoft Word\";  
        // an easier way to escape an entire string, is to use the '@' in front of the string...
        // in order to surround our string in '"', we escape this using an additional '"'.
        Console.WriteLine(pathToExe + exeFile);

        // Challenge - given the following string, make the output be what is desired... use both methods for escaping
        // Desired output: C:\Program Files\"Microsoft Programs"\'VisualStudio'
        Console.WriteLine("C:\\Program Files\\\"Microsoft Programs\"\\'VisualStudio'");
        Console.WriteLine(@"C:\Program Files\""Microsoft Programs""\'VisualStudio'");

        // string interpolation - escaping '{' using the same symbol
        string pathToExeV2 = @"C:\Program Files\Microsoft Word\";
        Console.WriteLine($"{{{pathToExeV2}{exeFile}}}");

        Console.WriteLine(separator);
        Console.WriteLine();

        // String Formatting
        string fruit = "strawberry";
        string juice = "juice";
        int dollarSigns = 10000;

        Console.WriteLine("{0, 15}", fruit); // second parameter to the replacement specifies where the last character of the string will land from the last printed character.
        Console.WriteLine("{0, 15}", juice);
        Console.WriteLine("{0, 15:C}", dollarSigns);
        Console.WriteLine($"{fruit, 15}");
        Console.WriteLine($"{juice, 15}");

        Console.WriteLine($"{dollarSigns, 15:C}"); // Currency

        Console.WriteLine(separator);
        Console.WriteLine();
        // Challenge
        string title = "Protein Intake Week: 1";
        int titleLength = title.Length;
        float day1 = 80.88557f;
        float day2 = 94.56465f;
        float day3 = 78.67893f;
        float day4 = 88.66654f;
        float day5 = 88.6466f;
        float day6 = 76.777f;
        float day7 = 91.85759f;
        float total = 600.0769f;
        string sep = new string('=', titleLength);
        int totalLength = titleLength - 6;

        Console.WriteLine("|{0}|", title);
        Console.WriteLine("|" + sep + "|");
        Console.WriteLine("|{0," + titleLength +":N2}|", day1);
        Console.WriteLine("|{0," + titleLength +":N2}|", day2);
        Console.WriteLine("|{0," + titleLength +":N2}|", day3);
        Console.WriteLine("|{0," + titleLength +":N2}|", day4);
        Console.WriteLine("|{0," + titleLength +":N2}|", day5);
        Console.WriteLine("|{0," + titleLength +":N2}|", day6);
        Console.WriteLine("|{0," + titleLength +":N2}|", day7);
        Console.WriteLine("|" + sep + "|");
        Console.WriteLine("|Total:{0," + totalLength +":N2}|", total);

    }
}
