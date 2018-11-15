using System;

class EntryPoint
{
    static void Main()
    {
        int choice = 0;
        bool newChoice = false;
        string[] fruits = new string[10];

        while (!newChoice)
        {
            int chosenFruit = 0;
            Console.Write("1. Add New Item" +
                "\n2. Edit Item" +
                "\n3. Remove Item" +
                "\n4. View All Items" +
                "\n5. Exit" +
                "\n Your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddItem(fruits);
                    break;
                case 2:
                    ListAllItems(fruits);
                    chosenFruit = EditItem(fruits);
                    break;
                case 3:
                    ListAllItems(fruits);
                    chosenFruit = RemoveItem(fruits);
                    break;
                case 4:
                    ListAllItems(fruits);
                    break;
                case 5:
                    newChoice = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static int EditItem(string[] fruits)
    {
        int chosenFruit;
        Console.Write("\nWhich fruit do you want to change (1 to 10): ");
        chosenFruit = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please input a new fruit that will substitute ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{fruits[chosenFruit - 1]}");
        Console.ResetColor();
        Console.Write(": ");

        fruits[chosenFruit - 1] = Console.ReadLine();
        return chosenFruit;
    }

    private static int RemoveItem(string[] fruits)
    {
        int chosenFruit;
        Console.Write("\nWhich fruit do you want to remove (1 to 10): ");
        chosenFruit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{fruits[chosenFruit - 1]} was removed.");
        fruits[chosenFruit - 1] = null;

        string[] tempArray = new string[fruits.Length];
        int tempArrayIndex = 0;

        for (int i = 0; i < fruits.Length; i++)
        {
            if (fruits[i] != null)
            {
                tempArray[tempArrayIndex] = fruits[i];
                tempArrayIndex++;
            }
        }

        Array.Copy(tempArray, fruits, tempArray.Length);
        return chosenFruit;
    }

    private static void AddItem(string[] fruits)
    {
        for (int i = 0; i < fruits.Length; i++)
        {
            if (fruits[i] == null)
            {
                Console.Write("Please add a new Fruit: ");
                fruits[i] = Console.ReadLine();
                break;
            }
        }
    }

    private static void ListAllItems(string[] fruits)
    {
        Console.WriteLine("\nCurrent Fruits: ");
        for (int i = 0; i < fruits.Length; i++)
        {
            if (fruits[i] != null)
            {
                Console.WriteLine($" {i + 1}. {fruits[i]}");
            }
        }
        Console.WriteLine();
    }
}
