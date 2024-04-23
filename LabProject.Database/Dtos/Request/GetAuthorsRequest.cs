using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject.Database.Dtos.Request
{
    public class GetAuthorsRequest
    {
        public string Name { get; set; }
        public SortingCriterionDto SortingCriterion { get; set; }
    }
}