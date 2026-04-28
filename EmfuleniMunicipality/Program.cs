using System;
using System.Collections.Generic;
using System.Text;

namespace EmfuleniMunicipality
{
    public class Program
    {
        static void Main(string[] args)
        {
            UtilitiesManager manager = new UtilitiesManager();
            Console.WriteLine("=== Welcome to Emfuleni Municipality Service Desk ===");

            Console.WriteLine("Enter number of residents :");
            int numberOfResidents = int.Parse(Console.ReadLine());
            List<Resident> residents = new List<Resident>();

            for (int i = 0; i < numberOfResidents; i++)
            {
                Console.WriteLine($"\n--- Enter details for Resident {i + 1} ---");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Address: ");
                string address = Console.ReadLine();
                Console.Write("Account Number: ");
                string accountNumber = Console.ReadLine();
                Console.Write("Monthly Utility Usage (kWh or liters): ");
                double monthlyUsage = double.Parse(Console.ReadLine());
                residents.Add(new Resident
                {
                    name = name,
                    address = address,
                    accountNumber = accountNumber,
                    monthlyUsage = monthlyUsage
                });
            }

            Console.WriteLine("\nHow many service requests do you want to log? : ");
            int numberOfRequests = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfRequests; i++)
            {
                Console.WriteLine($"\nService Request {i + 1} : ");
                ServiceRequest serviceRequest = new ServiceRequest();
                Console.Write($"Resident index (0 to 5): ");

                int residentIndex = int.Parse(Console.ReadLine());
                serviceRequest.resident = residents[residentIndex];

                Console.Write("Request Type (e.g., Water, Electricity, Waste Management): ");
                serviceRequest.requestType = Console.ReadLine();

                Console.Write("Priority (1 - 5 ) : ");
                serviceRequest.priorityLevel = int.Parse(Console.ReadLine());

                Console.Write("Severity (1 - 10 ) : ");
                serviceRequest.severityLevel = int.Parse(Console.ReadLine());

                Console.Write("Estimated Resolution Time (in hours) : ");
                serviceRequest.estimatedResolutionTime = int.Parse(Console.ReadLine());

                manager.addRequest(serviceRequest);
            }

            while (manager.serviceRequests.Count > 0)
            {
                Console.WriteLine("\nPending Requests  : ");

                for (int i = 0; i < manager.serviceRequests.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {manager.serviceRequests[i]}");
                }

                Console.Write("Select request index to process : ");
                int choice = int.Parse(Console.ReadLine());
                manager.processedRequest(choice);
            }

            manager.showSummary();
            Console.ReadKey();
        }
    }
}
