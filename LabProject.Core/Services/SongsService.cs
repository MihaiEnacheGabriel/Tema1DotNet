
using LabProject.Core.Mapping;
using LabProject.Database.Dtos.Request;
using LabProject.Database.Entities;
using LabProject.Database.Repositories;
using System.Collections.Generic;

namespace LabProject.Core.Services
{
    public class SongsService
    {
        private SongsRepository songsRepository { get; set; }

        public SongsService(SongsRepository songsRepository)
        {
            this.songsRepository = songsRepository;
        }

        public void AddSong(AddSongRequest payload)
        {
            var song = payload.ToEntity();

            songsRepository.Add(song);
        }

        public void AddSongs(List<AddSongRequest> payload)
        {
            var songs = payload.ToEntities();

            songsRepository.AddRange(songs);
        }
    }
}