using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Problem_Analysis_Mini_Project.Models
{
    public class DecisionAnalysis
    {
        public int ProblemId { get; set; }                // FK
        public List<string> Must { get; } = new();        // Must-have requirements
        public Dictionary<string, int> Wants { get; } = new(); // Want name → weight
        public List<AlternateSolution> Alternatives { get; } = new();

        public string ToJson() =>
            JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
    }
}