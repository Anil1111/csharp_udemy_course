using System;

class EntryPoint
{
    static void Main()
    {
        /*
        Console.Write("How old are you? ");
        // Reading a character... returns the ascii representation (integer) of a single character
        // So, to get the correct single character, you must typecast to a char!
        char age = (char)Console.Read();

        Console.WriteLine($"My age is {age}");
        */

        // ReadLine - reads an entire string, which we can repeat out to the console as-is.
        /*
        Console.Write("How old are you? ");
        string ageStr = Console.ReadLine();
        Console.WriteLine($"My age is {ageStr}");
        */

        /*
        Console.Write("How old are you? ");
        int age = int.Parse(Console.ReadLine());  // to make the age an integer, you must parse or convert...
        string strAge = Console.ReadLine();
        Console.WriteLine($"My age is {age + 1}"); // this will do integer math and actually add 1 to the age...
        Console.WriteLine($"My age is {strAge + 1}"); // this will concatenate 1 to the end of strAge...
        */

        // Challenge - read in 3 inputs...
        // Drive letter
        // Folder Path
        // file name of the executable
        Console.Write("Input the drive letter: ");
        string driveLetter = Console.ReadLine();
        Console.Write("Input the folder path: ");
        string folderPath = Console.ReadLine();
        Console.Write("Input the file name: ");
        string fileName = Console.ReadLine();

        //Console.WriteLine(driveLetter + ":\\" + folderPath + "\\" + fileName + ".exe");
        Console.WriteLine($"{driveLetter}:\\{folderPath}\\{fileName}.exe");

    }
}
