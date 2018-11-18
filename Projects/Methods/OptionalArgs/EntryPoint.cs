using System;

class EntryPoint
{
    static void Main()
    {
        Console.WriteLine(Multi(2, 3));
        ConnectToDB("Jerry", "123456");  // we can default the IP...

        Console.WriteLine(Sum(4, 2, 5));
        Console.WriteLine(Sum(4, 2));
        Console.WriteLine(Sum(4, 2, 0));
    }

    // optional argument will have a default value...
    static int Multi(int firstNumber, int secondNumber, int thirdNumber = 1)
    {
        return firstNumber * secondNumber * thirdNumber;
    }

    static void ConnectToDB(string username, string password, string ipAddress = "127.0.0.1")
    {
        Console.WriteLine($"Hello {username}, connecting to the database, please wait ...");
    }

    // challenge
    static int Sum(int a, int b, int c = 0)
    {
        return a + b + c;
    }
}
