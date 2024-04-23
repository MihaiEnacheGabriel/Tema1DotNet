using LabProject.Database.Context;
using LabProject.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LabProject.Database.Repositories
{
    public class SongsRepository : BaseRepository
    {
        public SongsRepository(LabProjectDbContext labProjectDbContext) : base(labProjectDbContext)
        {
        }

        public void Add(Song song)
        {
            labProjectDbContext.Songs.Add(song);
            labProjectDbContext.SaveChanges();
        }

        public void Update(Song song)
        {
            labProjectDbContext.Songs.Update(song);
            labProjectDbContext.SaveChanges();
        }

        public void Delete(int songId)
        {
            var song = labProjectDbContext.Songs.FirstOrDefault(s => s.Id == songId);
            if (song != null)
            {
                labProjectDbContext.Songs.Remove(song);
                labProjectDbContext.SaveChanges();
            }
        }
        public void AddRange(List<Song> songs)
        {
            labProjectDbContext.Songs.AddRange(songs);
            labProjectDbContext.SaveChanges();
        }

    }
}
