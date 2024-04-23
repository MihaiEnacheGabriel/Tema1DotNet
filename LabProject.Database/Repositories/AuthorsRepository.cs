using LabProject.Database.Context;
using LabProject.Database.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LabProject.Database.Repositories
{
    public class AuthorsRepository : BaseRepository
    {
        public AuthorsRepository(LabProjectDbContext labProjectDbContext) : base(labProjectDbContext)
        {
        }

        public void Add(Author author)
        {
            labProjectDbContext.Authors.Add(author);
            labProjectDbContext.SaveChanges();
        }

        public void Update(Author author)
        {
            labProjectDbContext.Authors.Update(author);
            labProjectDbContext.SaveChanges();
        }

        public void Delete(int authorId)
        {
            var author = labProjectDbContext.Authors.FirstOrDefault(a => a.Id == authorId);
            if (author != null)
            {
                labProjectDbContext.Authors.Remove(author);
                labProjectDbContext.SaveChanges();
            }
        }
    }
}
