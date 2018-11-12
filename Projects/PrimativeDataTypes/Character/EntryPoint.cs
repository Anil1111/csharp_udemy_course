using System;
using System.Text;

class EntryPoint
{
    static void Main()
    {
        // Set the console's encoding capabilities - for using special characters!
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        // Character datatype can only one character! - only in single quotes
        char theCharacterX = 'x';
        Console.WriteLine(theCharacterX);

        char thePlusSign = '\u002B';  // Hex code for ascii character - always use \u and 4 0s... replace the last 0s with the Hex code
        Console.WriteLine(thePlusSign);

        char strangeO = '\u00F6';
        Console.WriteLine(strangeO);

        char etherSymbol = '\u00C6';
        Console.WriteLine(etherSymbol);
    }
}
