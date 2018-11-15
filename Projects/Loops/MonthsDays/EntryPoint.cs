using System;

class EntryPoint
{
    static void Main()
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        int numDays = 0;
        int currentWeekDay = 0;

        for (int currentMonth = 0; currentMonth < months.Length; currentMonth++)
        {
            switch (months[currentMonth])
            {
                case "February":
                    numDays = 28;
                    break;
                case "April":
                case "June":
                case "September":
                case "November":
                    numDays = 30;
                    break;
                case "January":
                case "March":
                case "May":
                case "July":
                case "August":
                case "October":
                case "December":
                    numDays = 31;
                    break;
                default:
                    break;
            }

            // display the month...
            Console.WriteLine($"Month: {months[currentMonth]}");

            for (int currentDay = 1; currentDay <= numDays; currentDay++)
            {
                // reset the week day if we've gone 'out of bounds'
                if (currentWeekDay > 6)
                {
                    currentWeekDay = 0;
                }
                // Now display the day (and day of the week!)
                Console.WriteLine($" {currentDay} {weekDays[currentWeekDay]}");
                currentWeekDay++;
            }
        }
    }
}
