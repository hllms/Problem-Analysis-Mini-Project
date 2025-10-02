using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Analysis_Mini_Project.Core.Models
{

    public class AlternateSolution
    {
        public int ProblemId { get; set; }     // FK
        public int SolutionId { get; set; }    // PK
        public string SolutionName { get; set; } = string.Empty;

        // From UML: ratings / totals used in DA scoring
        public int WantRating { get; set; }
        public int WantScore { get; set; }
        public int SolutionTotal { get; set; } // we may replace with a computed Total later
    }
}
