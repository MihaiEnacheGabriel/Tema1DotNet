using LabProject.Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject.Database.Dtos.Request
{
    public class SortingCriterionDto
    {
        public SortingCriterion Criterion { get; set; }
        public SortingOrder Order { get; set; }
    }
}
