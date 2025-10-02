using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using Problem_Analysis_Mini_Project.Models;

namespace Problem_Analysis_Mini_Project.DevSupport;

public static class ModelSmoke
{
    public static void Run()
    {
        var problem = new Problem
        {
            ProblemId = 1,
            ProblemName = "Intermittent service outage",
            ProblemTime = Priority.High,
            ProblemTrend = Priority.Medium,
            ProblemImpact = Priority.High,
            ProblemFollowOn = TypeAnalysis.ProblemAnalysis
        };

        var pa = new ProblemAnalysis { ProblemId = problem.ProblemId };
        pa.For(PaProperty.What).Is.Add("Service down for 5–10 minutes");
        pa.For(PaProperty.What).IsNot.Add("Full-day outage");
        pa.For(PaProperty.When).Distinctions.Add("Peaks at :05 past the hour");
        pa.For(PaProperty.Where).ProbableCauses.Add("Cache eviction race");

        var da = new DecisionAnalysis { ProblemId = problem.ProblemId };
        da.Must.Add("No regression of SLA");
        da.Wants["Fast rollout"] = 3;
        da.Wants["Low complexity"] = 2;
        da.Alternatives.Add(new AlternateSolution
        {
            ProblemId = problem.ProblemId,
            SolutionId = 101,
            SolutionName = "Increase cache TTL",
            WantRating = 4,
            WantScore = 12,
            SolutionTotal = 16
        });

        var ppa = new PotentialProblemAnalysis
        {
            ProblemId = problem.ProblemId,
            PotentialProblems = "Cache growth could increase memory pressure",
            PossibleCauses = "TTL too long",
            PreventativeActions = "Add eviction monitoring",
            ContingencyPlan = "Auto-scale memory tier"
        };

        Debug.WriteLine("=== Problem ===");
        Debug.WriteLine(problem.ToJson());

        Debug.WriteLine("=== ProblemAnalysis (PA) ===");
        Debug.WriteLine(pa.ToJson());

        Debug.WriteLine("=== DecisionAnalysis (DA) ===");
        Debug.WriteLine(da.ToJson());

        Debug.WriteLine("=== PotentialProblemAnalysis (PPA) ===");
        Debug.WriteLine(ppa.ToJson());
    }
}
