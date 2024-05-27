using LabProject.Database.Context;
using LabProject.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


namespace LabProject.Database.Repositories
{
    public class RoleRepository : BaseRepository
    {
        private readonly DbSet<Role> _roles;

        public RoleRepository(LabProjectDbContext labProjectDbContext) : base(labProjectDbContext)
        {
            _roles = labProjectDbContext.Set<Role>();
        }

        public async Task<Role> GetByIdAsync(int id)
        {
            return await _roles.FindAsync(id);
        }

        public async Task<Role> GetByNameAsync(string name)
        {
            return await _roles
                .FirstOrDefaultAsync(r => r.Name == name);
        }

        public async Task AddAsync(Role role)
        {
            await _roles.AddAsync(role);
            await labProjectDbContext.SaveChangesAsync();
        }
    }
}
