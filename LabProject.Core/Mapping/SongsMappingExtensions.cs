using LabProject.Database.Dtos.Common;
using LabProject.Database.Dtos.Request;
using LabProject.Database.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LabProject.Core.Mapping
{
    public static class SongsMappingExtensions
    {
        public static List<Song> ToEntities(this List<AddSongRequest> dtos)
        {
            var results = dtos.Select(e => e.ToEntity()).ToList();

            return results;
        }

        public static Song ToEntity(this AddSongRequest dto)
        {
            if (dto == null) return null;

            var result = new Song();
            result.Title = dto.Title;
            result.AuthorId = dto.AuthorId;

            result.DateCreated = DateTime.UtcNow;
            result.DateUpdated = DateTime.UtcNow;

            return result;
        }
    }
}
