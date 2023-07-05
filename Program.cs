using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_of_structures
{
    struct Birthday
    {
        private DateTime dateOfBirth;

        public void SetDateOfBirth(int year, int month, int day)
        {
            dateOfBirth = new DateTime(year, month, day);
        }

        public string GetDayOfWeekOfBirth()
        {
            return dateOfBirth.DayOfWeek.ToString();
        }

        public string GetDayOfWeekInYear(int year)
        {
            DateTime birthdayInYear = new DateTime(year, dateOfBirth.Month, dateOfBirth.Day);
            return birthdayInYear.DayOfWeek.ToString();
        }

        public int GetDaysUntilBirthday()
        {
            DateTime today = DateTime.Today;
            DateTime nextBirthday = new DateTime(today.Year, dateOfBirth.Month, dateOfBirth.Day);

            if (nextBirthday < today)
                nextBirthday = nextBirthday.AddYears(1);

            return (nextBirthday - today).Days;
        }
    }

    class Programdate
    {
        public static void Main()
        {
            Birthday birthday = new Birthday();

           
            birthday.SetDateOfBirth(2000, 4, 1);

            string dayOfWeekOfBirth = birthday.GetDayOfWeekOfBirth();
            Console.WriteLine($"День народження припадає на {dayOfWeekOfBirth}");

            string dayOfWeekInYear = birthday.GetDayOfWeekInYear(2025);
            Console.WriteLine($"У 2025 році день народження припаде на {dayOfWeekInYear}");

            int daysUntilBirthday = birthday.GetDaysUntilBirthday();
            Console.WriteLine($"До дня народження залишилося {daysUntilBirthday} днів");
        }
    }
}
