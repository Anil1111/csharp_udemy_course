using System;

// && - AND
// || - OR
// !  - NOT

class EntryPoint
{
    static void Main()
    {
        int number = 15;
        bool lessThan = number < 20;
        bool moreThan = number > 5;

        Console.WriteLine(lessThan);
        Console.WriteLine(moreThan);

        bool isInRange = lessThan && moreThan;
        Console.WriteLine(isInRange);

        number = 25;  // Now we must do our comparisons again!
        lessThan = number < 20;
        moreThan = number > 5;

        isInRange = lessThan && moreThan;
        Console.WriteLine(isInRange);

        // challenge
        string username = "prettyboy66";
        // longer than 6 chars
        // OR first character is a capital.

        bool longerThan6 = username.Length > 6;
        bool firstLetterCap = Char.IsUpper(username[0]);
        Console.WriteLine(longerThan6);
        Console.WriteLine(firstLetterCap);
        bool isEither = longerThan6 || firstLetterCap;
        Console.WriteLine(isEither);
        bool usernameConditions = username.Length > 6 || Char.IsUpper(username[0]);
        Console.WriteLine(usernameConditions);

        // challenge
        // username length is between 5 and 14 and first character is lowercase and is not equal to "admin"
        // OR...
        // range is now 6 to 14 and first character is not a number

        bool condition1 = (username.Length >= 5 && username.Length <= 14) && Char.IsLower(username[0]) && username != "admin";
        bool condition2 = (username.Length >= 6 && username.Length <= 14) && !Char.IsNumber(username[0]);
        bool allConditions = condition1 || condition2;
        Console.WriteLine(condition1);
        Console.WriteLine(condition2);
        Console.WriteLine(allConditions);
    }
}
