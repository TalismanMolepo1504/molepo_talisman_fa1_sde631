using System;          
using System.Linq;

namespace StudentResults
{
    public class Program
    {
        static void Main()
        {
            // prompt for the student name
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();


            
            int[] marks = new int[3];


            // collecting marks for each subject
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Enter mark for Subject {i + 1}: ");

                
                while (!int.TryParse(Console.ReadLine(), out marks[i]))
                {
                    Console.Write("Invalid input. Enter numeric value: ");
                }
            }

            // calculating total marks
            int total = marks.Sum();


            // calculating average mark
            double average = marks.Average();


            string result = average >= 50 ? "PASS" : "FAIL"; 

            
            Console.WriteLine("\n===== STUDENT RESULTS =====");
            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average Marks: {average:F1}");
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Result Issued At: {DateTime.Now}");
            
            Console.ReadKey();
        }
    }
}