using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject.Database.Entities
{
    public class Song : BaseEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }

    }
}
