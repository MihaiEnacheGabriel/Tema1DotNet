using LabProject.Core.Mapping;
using LabProject.Database.Dtos.Request;
using LabProject.Database.Entities;
using LabProject.Database.Repositories;

namespace LabProject.Core.Services
{
    public class AuthorsService
    {
        private AuthorsRepository authorsRepository { get; set; }

        public AuthorsService(AuthorsRepository authorsRepository)
        {
            this.authorsRepository = authorsRepository;
        }

        public void AddAuthor(AddAuthorRequest payload)
        {
            var author = payload.ToEntity();

            authorsRepository.Add(author);
        }

    }
}
