using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Problem_Analysis_Mini_Project.Models
{

    public class PotentialProblemAnalysis
    {
        public int ProblemId { get; set; } = 0;            // FK
        public string PotentialProblems { get; set; } = "";
        public string PossibleCauses { get; set; } = "";
        public string PreventativeActions { get; set; } = "";
        public string ContingencyPlan { get; set; } = "";

        public string ToJson() =>
            JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });

        // Placeholder for a future report generator
        public string WriteReport() => $"PPA Report for Problem #{ProblemId}";
    }
}

