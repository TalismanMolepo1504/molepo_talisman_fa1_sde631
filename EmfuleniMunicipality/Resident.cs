using System;
using System.Collections.Generic;
using System.Text;

namespace EmfuleniMunicipality
{
    public class Resident
    {
        public string name { get; set; }
        public string address { get; set; }
        public string accountNumber { get; set; }
        public double monthlyUsage { get; set; }

        public override string ToString()
        {

            return $"Name: {name}," +
                $" Address: {address}, " +
                $"Account Number: {accountNumber}," +
                $" Monthly Utility Usage (kWh or lires ): {monthlyUsage}";
        }
    }
}
