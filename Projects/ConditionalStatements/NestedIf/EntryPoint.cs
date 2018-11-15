using System;

class EntryPoint
{
    static void Main()
    {
        string username = string.Empty;
        string password = string.Empty;

        Console.Write("Enter your username: ");
        username = Console.ReadLine();

        if (username == "admin")
        {
            Console.Write("Welcome admin, please input your password: ");
            password = Console.ReadLine();

            if (password == "password")
            {
                Console.WriteLine("Welcome admin! Full access has been granted to you!");
            }
            else
            {
                Console.WriteLine("Sorry your password is incorrect!");
            }
        }
        else
        {
            Console.WriteLine("Sorry your username is incorrect!");
        }

        // challenge
        // take in 3 inputs and sorts in ascending order
        int firstNum, secondNum, thirdNum;

        firstNum = Convert.ToInt32(Console.ReadLine());
        secondNum = Convert.ToInt32(Console.ReadLine());
        thirdNum = Convert.ToInt32(Console.ReadLine());

        if (firstNum < secondNum && firstNum < thirdNum)
        {
            if (secondNum < thirdNum)
            {
                Console.WriteLine($"{firstNum} {secondNum} {thirdNum}");
            }
            else
            {
                Console.WriteLine($"{firstNum} {thirdNum} {secondNum}");
            }
        }
        else if (secondNum < firstNum && secondNum < thirdNum)
        {
            if (firstNum < thirdNum)
            {
                Console.WriteLine($"{secondNum} {firstNum} {thirdNum}");
            }
            else
            {
                Console.WriteLine($"{secondNum} {thirdNum} {firstNum}");
            }
        }
        else if (thirdNum < firstNum && thirdNum < secondNum)
        {
            if (firstNum < secondNum)
            {
                Console.WriteLine($"{thirdNum} {firstNum} {secondNum}");
            }
            else
            {
                Console.WriteLine($"{thirdNum} {secondNum} {firstNum}");
            }
        }

    }
}
