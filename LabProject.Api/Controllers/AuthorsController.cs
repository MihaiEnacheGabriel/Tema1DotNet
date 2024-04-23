using LabProject.Core.Services;
using LabProject.Database.Dtos.Request;
using Microsoft.AspNetCore.Mvc;

namespace LabProject.Api.Controllers
{
    [Route("api/authors")]
    public class AuthorsController : ControllerBase
    {
        private AuthorsService authorsService { get; set; }

        public AuthorsController(AuthorsService authorsService)
        {
            this.authorsService = authorsService;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddAuthor([FromBody] AddAuthorRequest payload)
        {
            authorsService.AddAuthor(payload);

            return Ok("Author has been successfully added");
        }

    }
}
