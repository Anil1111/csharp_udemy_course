using System;

class EntryPoint
{
    static void Main()
    {
        string player1Name = "Jerry";
        string player2Name = "Levi";

        string player1Class = "Warrior";
        string player2Class = "Wizard";

        int player1Health = 100;
        int player2Health = 100;

        int damage;
        Random rnd = new Random();

        while (player1Health > 0 && player2Health > 0)
        {
            // player 1 attacks first
            damage = rnd.Next(1, 10);
            player2Health -= damage;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{player1Class} {player1Name} dealt {damage} damage to {player2Class} {player2Name}. {player2Name} now has {player2Health} health.");

            if (player2Health > 0)
            {
                damage = rnd.Next(1, 10);
                player1Health -= damage;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{player2Class} {player2Name} dealt {damage} damage to {player1Class} {player1Name}. {player1Name} now has {player1Health} health.");
            }
        }
        Console.ForegroundColor = ConsoleColor.Green;
        if (player1Health > 0)
        {
            Console.WriteLine($"{player1Class} {player1Name} has won the battle with {player1Health} health!");
        } else
        {
            Console.WriteLine($"{player2Class} {player2Name} has won the battle with {player2Health} health!");
        }
        Console.ResetColor();
    }
}
