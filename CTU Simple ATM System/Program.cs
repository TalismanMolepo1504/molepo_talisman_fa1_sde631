using System;

namespace CTU_SIMPLE_ATM_SYSTEM
{
    public class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("==== WELCOME TO CTU SIMPLE ATM SYSTEM ====\n");

            // capturing the user name and greeting
            Console.WriteLine("HI , WHAT IS YOUR NAME?");
            string name = Console.ReadLine();

            Console.WriteLine("\nWELCOME " + name);

            // getting the balance & the amount to be withdrawn

            Console.Write("\nEnter account balance : ");
            double balance = double.Parse(Console.ReadLine());

            Console.Write("Enter withdrawal amount : ");
            double withdrawalAmount = double.Parse(Console.ReadLine());

            if(withdrawalAmount > balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                balance -= withdrawalAmount;
                Console.WriteLine($"\nWithdrawal successful!\nUpdated Balance: {balance:F2}");
                Console.WriteLine("Transaction Time: " + DateTime.Now);
            }

            Console.ReadKey();
        }
    }
}
