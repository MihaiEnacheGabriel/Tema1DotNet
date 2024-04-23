using LabProject.Database.Dtos.Request;
using LabProject.Database.Entities;

namespace LabProject.Core.Mapping
{
    public static class AuthorsMappingExtensions
    {
        public static Author ToEntity(this AddAuthorRequest dto)
        {
            if (dto == null) return null;

            var result = new Author();
            result.Name = dto.Name;

            result.DateCreated = DateTime.UtcNow;
            result.DateUpdated = DateTime.UtcNow;

            return result;
        }
    }
}