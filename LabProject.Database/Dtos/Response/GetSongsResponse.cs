using LabProject.Database.Dtos.Common;
using System.Collections.Generic;

namespace LabProject.Database.Dtos.Response
{
    public class GetSongsResponse
    {
        public List<SongDto> Songs { get; set; }
        public int Count { get; set; }
    }
}
