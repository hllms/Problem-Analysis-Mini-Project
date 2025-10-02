using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_Analysis_Mini_Project.Models;
using System.Text.Json;


namespace Problem_Analysis_Mini_Project.Models
{




    public class Problem
    {
        // Properties (from UML)
        public int ProblemId { get; set; }                     // PK
        public string ProblemName { get; set; } = string.Empty;
        public Priority ProblemTime { get; set; }              // urgency/time pressure
        public Priority ProblemTrend { get; set; }             // getting worse/better
        public Priority ProblemImpact { get; set; }            // severity/impact
        public TypeAnalysis ProblemFollowOn { get; set; }      // PA, DA, or PPA

        // Methods (initial stubs)
        public bool ValidateEntries() =>
            ProblemId >= 0 && !string.IsNullOrWhiteSpace(ProblemName);

        // Simple scoring example; we can refine later to match your logic
        public int Rank() => (int)ProblemImpact * 2 + (int)ProblemTrend + (int)ProblemTime;

        public string ToJson() =>
            JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
    }
}

