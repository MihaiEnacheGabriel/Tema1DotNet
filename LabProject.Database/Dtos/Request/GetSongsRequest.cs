using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject.Database.Dtos.Request
{
    public class GetSongsRequest
    {
        public string Title { get; set; }
        public int? AuthorId { get; set; }
        public SortingCriterionDto SortingCriterion { get; set; }
    }
}
