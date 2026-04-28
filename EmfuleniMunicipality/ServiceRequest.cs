using System;
using System.Collections.Generic;
using System.Text;

namespace EmfuleniMunicipality
{
    public class ServiceRequest
    {
        public Resident resident { get; set; }
        public string requestType { get; set; }
        public int priorityLevel { get; set; }
        public int severityLevel { get; set; }
        public int estimatedResolutionTime { get; set; }

        public double calculateUrgency()
        {
            // formula = for calculating the urgency 
            return (priorityLevel * 2) + (severityLevel / (double)estimatedResolutionTime);
        }

        public override string ToString()
        {
            return $"Resident: {resident}," +
                $" Service Type: {requestType}," +
                $" Priority Level (1-5): {priorityLevel}," +
                $" Severity Level (1-10): {severityLevel}," +
                $" Estimated Resolution Time: {estimatedResolutionTime}," +
                $" Urgency Score: {calculateUrgency()}";
        }


    }
}
