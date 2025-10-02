using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;

namespace Problem_Analysis_Mini_Project.Core.Models
{

    public class ProblemAnalysis
    {
        public int ProblemId { get; set; }  // FK to Problem

        // Key: What/When/Where/Extent  → Value: PaFacts (Is, IsNot, Distinctions, ProbableCauses)
        public Dictionary<PaProperty, PaFacts> Facts { get; } = new();

        // Helper to get/create a facts bucket
        public PaFacts For(PaProperty prop)
        {
            if (!Facts.TryGetValue(prop, out var facts))
            {
                facts = new PaFacts();
                Facts[prop] = facts;
            }
            return facts;
        }

        public string ToJson() =>
            JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
    }
}
