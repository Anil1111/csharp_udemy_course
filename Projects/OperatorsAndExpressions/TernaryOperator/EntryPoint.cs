using System;

class EntryPoint
{
    static void Main()
    {
        // expression ? true side : false side;
        string incomingTempUsername = "prettyboy66"; // this will be returned to username since it meets the expression as true
        //string incomingTempUsername = "pret"; // this will fail, so default_user will be returned instead.
        string username = incomingTempUsername.Length > 6 ? incomingTempUsername : "default_user";

        // challenge - change the console to green if greater than 6 or red if not
        Console.ForegroundColor = incomingTempUsername.Length > 6 ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine(username);
        Console.ResetColor();

    }
}
