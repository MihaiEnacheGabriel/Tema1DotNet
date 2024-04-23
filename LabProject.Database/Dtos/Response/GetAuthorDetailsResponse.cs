using LabProject.Database.Dtos.Common;

namespace LabProject.Database.Dtos.Response
{
    public class GetAuthorDetailsResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SongDto> Songs { get; set; }
    }
}
