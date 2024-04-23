using System;

namespace LabProject.Database.Dtos.Common
{
    public class SongDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }
}
