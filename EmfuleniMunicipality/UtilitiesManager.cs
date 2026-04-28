using System;
using System.Collections.Generic;
using System.Text;

namespace EmfuleniMunicipality
{
    public class UtilitiesManager
    {
        public List<ServiceRequest> serviceRequests { get; set; }
        public List<ServiceRequest> processedRequests { get; set; }


        public void addRequest(ServiceRequest request)
        {
            serviceRequests.Add(request);
        }

        public void processedRequest(int index)
        {
            if (index >= 0 && index < serviceRequests.Count)
            {
                var req = serviceRequests[index];
                processedRequests.Add(req);
                serviceRequests.RemoveAt(index);

                Console.WriteLine("\n=--- Service Report --- ");
                Console.WriteLine(req.resident);
                Console.WriteLine(req);
                Console.WriteLine("---------------------------------\n");
            }
            
        }

        public void showSummary()
        {
            Console.WriteLine("\n=== Service Report ===");

            foreach (var req in processedRequests)
            {
                Console.WriteLine(req.resident);
                Console.WriteLine(req);
                Console.WriteLine("---------------------------------");
            }

            var highest = processedRequests.OrderByDescending(r => r.calculateUrgency()).FirstOrDefault();

            if(highest != null)
            {
                Console.WriteLine("\n=== Highest Urgency Request ===");
                Console.WriteLine(highest.resident);
                Console.WriteLine(highest);
                Console.WriteLine("---------------------------------");
            }


        }


    }
}
