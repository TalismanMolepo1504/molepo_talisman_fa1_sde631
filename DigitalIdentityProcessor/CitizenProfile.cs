using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalIdentityProcessor
{
    public class CitizenProfile
    {
        public string fullName { get; set; }
        public string IDNumber { get; set; }
        public int age { get; set; }
        public string citizenshipStatus { get; set; }

        public CitizenProfile(string fullName, string IDNumber, int age, string citizenshipStatus)
        {
            this.fullName = fullName;
            this.IDNumber = IDNumber;
            this.citizenshipStatus = citizenshipStatus;

            age = calculateAge();
        }

        public CitizenProfile(string fullName, string IDNumber, string? citizenshipStatus)
        {
            this.fullName = fullName;
            this.IDNumber = IDNumber;
            this.citizenshipStatus = citizenshipStatus;
        }

        private int calculateAge()
        {
            if (IDNumber.Length < 6)
            {
                return 0;
            }

            string birthYear = IDNumber.Substring(0, 2);
            string birthMonth = IDNumber.Substring(2, 2);
            string birthDay = IDNumber.Substring(4, 2);

            int fullYear = (int.Parse(birthYear) <= DateTime.Now.Year % 100) ? 2000 + int.Parse(birthYear) : 1900 + int.Parse(birthYear);
            

            DateTime birthDate = new DateTime(fullYear, int.Parse(birthMonth), int.Parse(birthDay));
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age--;
            }
            return age;
        }

        public string validateID()
        {
            if (string.IsNullOrWhiteSpace(IDNumber))
                return "ID cannot be empty";
            ;
            if (IDNumber.Length != 13 || !long.TryParse(IDNumber, out _))
                return "ID must be 13 digits long and numeric";
            if (age <= 0)
                return "Invalid birth date ";
            if (citizenshipStatus != "Citizen" && citizenshipStatus != "Permanent Resident")
                return "Invalid citizenship status";
            return "Valid ID. Citizen is " + age + " years old";
        }

        public string GenerateProfile()
        {
            return $"--- Citizen Profile ---" +
                $" Name: {fullName}" +
                $"\nID Number: {IDNumber}" +
                $"\nAge: {age}\n" +
                $"Citizenship Status: {citizenshipStatus}" +
                $"Validation : {validateID()}"+
                $"Processed at : {DateTime.Now}";
        }
    }
}
