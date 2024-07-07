using AutoMapper;
using Domain.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Author;
using Service.Services.Interfaces;


namespace LibraryAPI.Controllers.Admin
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;
        public AuthorController(IAuthorService authorService,
            IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }


        // GET api/values/5
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var authors = await _authorService.GetAll();
            var mappedAuthors = _mapper.Map<IEnumerable<AuthorDto>>(authors);
            return Ok(mappedAuthors);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]AuthorCreateDto request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var mappedAuthor = _mapper.Map<Author>(request);
            await _authorService.Create(mappedAuthor);
            return CreatedAtAction(nameof(Post), mappedAuthor);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute]int ?id)
        {
            if (id is null) return BadRequest(ModelState);
            var author = await _authorService.GetBy(m => m.Id == id);
            if (author is null) return NotFound();
            await _authorService.Delete(author);
            return Ok();
        }
    }
}

