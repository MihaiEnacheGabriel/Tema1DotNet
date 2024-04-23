using LabProject.Database.Enums;

namespace LabProject.Database.Entities
{
    public class Author : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Song> Songs { get; set; }
    }
}
