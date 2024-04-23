using LabProject.Database.Dtos.Common;
using System.Collections.Generic;

namespace LabProject.Database.Dtos.Response
{
    public class GetSongDetailsResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
