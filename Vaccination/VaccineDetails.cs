using System;
using System.Collections.Generic;
using System.Text;

namespace Vaccination
{
   public class VaccineDetails
    {
        public string Vaccine;
        public string gender;
        public enum VaccineType
        {
            covishield,
            covaccine,
            sputnic,
        }
        public VaccineType V;
       public int type1;
        public string Vccine()
        {
            V = (VaccineType)type1;
            return type1.ToString();
        }
        public enum Gender
        {
            Male,
            Female,
            Others,
        }
        public Gender g;
        public int type2;

        public string UserName { get; internal set; }
        public string VaccinType { get; internal set; }
        public long PhoneNumber { get; internal set; }
        public int Dose { get; set; }
        public string City { get; set; }
        public int RegisterNumber { get; internal set; }

        public  string Gen()
        {
            g = (Gender)type2;
            return type2.ToString();
        }
       
        


    }
}
