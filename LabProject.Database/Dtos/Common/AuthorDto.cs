using System;
using System.Collections.Generic;

namespace LabProject.Database.Dtos.Common
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SongDto> Songs { get; set; }
    }
}
