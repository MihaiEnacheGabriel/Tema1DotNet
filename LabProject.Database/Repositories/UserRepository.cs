using LabProject.Database.Context;
using LabProject.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LabProject.Database.Repositories
{
    public class UserRepository : BaseRepository
    {
        private readonly DbSet<User> _users;

        public UserRepository(LabProjectDbContext labProjectDbContext) : base(labProjectDbContext)
        {
            _users = labProjectDbContext.Set<User>();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _users.FindAsync(id);
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            return await _users
                .FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task AddAsync(User user)
        {
            await _users.AddAsync(user);
            await labProjectDbContext.SaveChangesAsync();
        }
    }
}
