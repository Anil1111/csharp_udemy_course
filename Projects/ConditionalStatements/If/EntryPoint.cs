using System;

class EntryPoint
{
    static void Main()
    {
        int firstNumber = 4;
        int secondNumber = 5;

        if (firstNumber > secondNumber)
        {
            Console.WriteLine("4 is less than 5.");
        }
        else
        {
            Console.WriteLine("4 is bigger than 5.");
        }
        Console.WriteLine("I am after the IF statement.");

        // Challenge
        string username = string.Empty;
        string password = string.Empty;
        Console.Write("Enter your username: ");
        string tempUsername = Console.ReadLine();
        Console.Write("Enter your password: ");
        string tempPassword = Console.ReadLine();

        if (tempUsername.Length >= 6)
        {
            username = tempUsername;
        }
        else
        {
            username = "default_user";
        }

        if (tempPassword.Length >= 8)
        {
            password = tempPassword;
        }
        else
        {
            password = "default_secret";
        }

        Console.WriteLine(tempUsername);
        Console.WriteLine(username);
        Console.WriteLine(tempPassword);
        Console.WriteLine(password);
    }
}
