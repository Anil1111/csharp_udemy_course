using System;

class EntryPoint
{
    static void Main()
    {
        int firstNumber = 5;
        int secondNumber = 5;

        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"The number {firstNumber} is bigger than the number {secondNumber}");
        }
        else if (firstNumber < secondNumber)
        {
            Console.WriteLine($"The number {firstNumber} is NOT bigger than the number {secondNumber}");
        }
        else
        {
            Console.WriteLine($"The number {firstNumber} is equal to the number {secondNumber}");
        }

        // challenge
        int numKills = 60;
        string playerName = "Jerry";
        int score = 0;

        if (numKills == 100)
        {
            score += 10000;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{playerName} has won the game! {playerName} finished with a score of {score}!");
            Console.ResetColor();
        }
        else if (numKills >= 75 && numKills <= 99)
        {
            score += 5000;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{playerName} has won the game! {playerName} finished with a score of {score}!");
            Console.ResetColor();
        }
        else if (numKills >= 50 && numKills <= 74)
        {
            score += 1000;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{playerName} has survived! {playerName} finished with a score of {score}!");
            Console.ResetColor();
        }
        else if (numKills < 50)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{playerName} has lost the game! {playerName} finished with a score of {score}!");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Invalid number of killed enemies!");
        }
    }
}
