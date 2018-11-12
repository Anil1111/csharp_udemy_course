using System;

class EntryPoint
{
    static void Main()
    {
        /*
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine("A turtle made it to the water.");
        Console.WriteLine("I've collected many things over the years.");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The cycle of life can be cruel.");

        Console.ResetColor();
        */

        // Challenge:
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

        // Set console view/size
        Console.SetWindowSize(titleLength + 3, 16);
        Console.SetBufferSize(titleLength + 3, 16);
        Console.SetWindowPosition(0, 0);

        // set console colors
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("|" + sep + "|");
        Console.Write("|");
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.Write("{0}", title);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("|\n");
        Console.WriteLine("|" + sep + "|");
        Console.Write("|");
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write("{0," + titleLength + ":N2}", day1);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("|\n");
        Console.Write("|");
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write("{0," + titleLength + ":N2}", day2);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("|\n");
        Console.Write("|");
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write("{0," + titleLength + ":N2}", day3);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("|\n");
        Console.Write("|");
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write("{0," + titleLength + ":N2}", day4);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("|\n");
        Console.Write("|");
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write("{0," + titleLength + ":N2}", day5);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("|\n");
        Console.Write("|");
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write("{0," + titleLength + ":N2}", day6);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("|\n");
        Console.Write("|");
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Write("{0," + titleLength + ":N2}", day7);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("|\n");
        Console.WriteLine("|" + sep + "|");
        Console.Write("|");
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Write("Total:{0," + totalLength + ":N2}", total);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("|\n");
        Console.WriteLine("|" + sep + "|");
        Console.ResetColor();
    }
}
