class EntryPoint
{
    static void Main()
    {
        int bigNumber = 234235234;

        // ToString() method allows you to treat any datatype as a string to do string operations...
        System.Console.WriteLine(bigNumber.ToString().Contains("5"));
        System.Console.WriteLine(bigNumber.ToString().IndexOf("5"));
        System.Console.WriteLine(bigNumber.ToString().LastIndexOf("5"));

        string iLearn = "I am learning";
        string nameOfCourse = "C# Master course";

        // concatenation of any datatype becomes a string...
        string concatenated = iLearn + nameOfCourse + bigNumber;

        System.Console.WriteLine(iLearn + " " + nameOfCourse);
        System.Console.WriteLine(concatenated);

        // String Building...
        string nameOfCharacter = "Draco";
        string spellName = "Fireball";
        int damageTaken = 100;

        // Concatenation
        string damageReport = "The " + nameOfCharacter + " character took " + damageTaken + " damage from " + spellName;
        // replacement using placeholders
        string damageReportV2 = string.Format("The {0} character took {1} damage from {2}", nameOfCharacter, damageTaken, spellName);
        // replacement with variable reuse...
        string damageReportV21 = string.Format("The {0} character took {1} damage from {2}, and the character {0} is now dead.", nameOfCharacter, damageTaken, spellName);

        System.Console.WriteLine(damageReport);
        System.Console.WriteLine(damageReportV2);
        System.Console.WriteLine(damageReportV21);

        // String interpolation - better for readability
        string damageReportV3 = $"The {nameOfCharacter} character took {damageTaken} damage from {spellName}";
        System.Console.WriteLine(damageReportV3);
    }
}
