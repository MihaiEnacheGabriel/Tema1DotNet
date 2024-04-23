using LabProject.Database.Dtos.Common;
using System.Collections.Generic;

namespace LabProject.Database.Dtos.Response
{
    public class GetAuthorsResponse
    {
        public List<AuthorDto> Authors { get; set; }
        public int Count { get; set; }
    }
}
