using System;
using System.Collections.Generic;
using System.Text;

namespace Vaccination
{
    public class UserDetails
    {
        public string UserName { get; set; }
        public long PhoneNumber { get; set; }
        public string city { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Dose { get; set; }
        public int RegisterNumber = 1001;
        public static int NextVaccine()
        {
            Console.WriteLine("Enter your first vaccination date");
            Console.WriteLine("enter month");
            int month = int.Parse(Console.ReadLine());
            month += 1;
            Console.WriteLine("Enter day");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(month / day / year);
            //return date.AddMonths(1);
            return month / day / year;

        }

        public int AutoIncement()
        {
            return RegisterNumber++;
        }
       
    }
}
