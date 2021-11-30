using System;
using System.Collections.Generic;

namespace Vaccination
{
    class Program
    {
        static void Main(string[] args)
        {

            List<VaccineDetails> users = new List<VaccineDetails>();
            VaccineDetails users1 = new VaccineDetails();
            VaccineDetails users2 = new VaccineDetails();
            VaccineDetails users3 = new VaccineDetails();
            VaccineDetails users4 = new VaccineDetails();
            UserDetails userdetails = new UserDetails();
            VaccineDetails vaccinne = new VaccineDetails();
            users1.UserName = "Gopi";
            users1.RegisterNumber = 1001;
            users1.VaccinType = "Covaccine";
            users1.PhoneNumber = 1234567890;

            users.Add(users1);
            users2.UserName = "siva";
            users2.RegisterNumber = 1002;
            users2.VaccinType = "Covaccine";
            users2.PhoneNumber = 9807654321;

            users.Add(users2);
            users3.UserName = "siva kumar";
            users3.RegisterNumber = 1003;
            users3.VaccinType = "Sputnic";
            users3.PhoneNumber = 9807474321;

            users.Add(users3);


            Console.WriteLine("enter 1.Benficiary Registration\n 2.vaccination\n 3.Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter your name");
                    users4.UserName = Console.ReadLine();
                    Console.WriteLine("Enter mobile number");
                    users4.PhoneNumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Addres");
                    string addres = Console.ReadLine();
                    Console.WriteLine("Enter Age");
                    int Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter gender");
                    users4.type2 = int.Parse(Console.ReadLine());
                    users4.gender = vaccinne.Gen();
                    string gender = Console.ReadLine();
                    Console.WriteLine("Enter city name");
                    users4.City = Console.ReadLine();
                    Console.WriteLine("your registration is completed");
                    Console.WriteLine("your registration ID is");
                    users4.RegisterNumber = userdetails.AutoIncement();
                    Console.WriteLine(users4.RegisterNumber);

                    break;
                case 2:
                    Console.WriteLine("Enter Register Number");
                    int RegisterNumber = int.Parse(Console.ReadLine());
                    foreach (var item in users)
                    {
                        if (item.RegisterNumber == RegisterNumber)
                        {

                            Console.WriteLine("Enter 1.Take vaccination\n2.Vaccine History\n3.DueDate\n4.Exit");
                            users4.type1 = int.Parse(Console.ReadLine());
                            //users4.Dose = vaccinne.Vaccine();
                            int choice1 = int.Parse(Console.ReadLine());
                            // if (choice1 == 1)
                            switch (choice1)
                            {
                                case 1:
                                    Console.WriteLine("Enter type of vaccination\n 1.Covishield\n2.covaccine\n3.sputnic");
                                    users4.VaccinType = (Console.ReadLine());
                                    foreach (var i in users)
                                    {
                                        users.Add(users4);
                                    }
                                    break;



                                //Vaccine History
                                case 2:
                                    foreach (var item1 in users)
                                    {
                                        if (item1.RegisterNumber == RegisterNumber)
                                        {
                                            Console.WriteLine(users4);
                                        }
                                    }
                                    break;


                                //Due Date
                                case 3:

                                    Console.WriteLine(UserDetails.NextVaccine());
                                    foreach (var item2 in users)
                                    {
                                        if (item2.Dose == 2)
                                        {
                                            Console.WriteLine("You have completed the vaccination course");
                                        }
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Invalid Registration Number");
                                    break;

                            }

                        }
                    }
                    break;
                default:
                    Console.WriteLine("Go to main menu");
                    break;
            }
            
            

        }
     
    }
}
