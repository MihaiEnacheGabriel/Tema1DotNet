
using LabProject.Core.Services;
using LabProject.Database.Dtos.Request;
using Microsoft.AspNetCore.Mvc;

namespace LabProject.Api.Controllers
{
    [Route("api/songs")]
    public class SongsController : ControllerBase
    {
        private SongsService songsService { get; set; }

        public SongsController(SongsService songsService)
        {
            this.songsService = songsService;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddSong([FromBody] AddSongRequest payload)
        {
            songsService.AddSong(payload);

            return Ok("Song has been successfully created");
        }

    }
}