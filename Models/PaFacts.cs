using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Problem_Analysis_Mini_Project.Models;

public sealed class PaFacts
{
    public List<string> Is { get; } = new();
    public List<string> IsNot { get; } = new();
    public List<string> Distinctions { get; } = new();
    public List<string> ProbableCauses { get; } = new();
}
