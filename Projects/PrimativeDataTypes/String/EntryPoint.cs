class EntryPoint
{
    static void Main()
    {
        string userName = "admin";  // strings use double quotes.
        System.Console.WriteLine(userName[0]);  // strings allow you to fetch single characters by using the character's index

        // Strings are immutable - meaning they're readonly after the first assignment...
        // so, we can't do something like this: userName[3] = 'd';

    }
}

