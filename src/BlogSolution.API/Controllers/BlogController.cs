using BlogSolution.Business.Services.Interfaces;
using BlogSolution.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSolution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogServices _blogServices;

        public BlogController(IBlogServices blogServices)
        {
            _blogServices = blogServices;
        }

        [HttpPost ("")]
        public async Task CreateAsync(Blog blog)
        {
            _blogServices.CreateAsync(blog);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _blogServices.Delete(id);
        }

        [HttpGet("")]
        public async Task GetOne(int id)
        {
            _blogServices.GetOneById(id);
        }

        [HttpDelete("[action]/{id}")]
        public void SoftDelete(int id)
        {
            _blogServices.SoftDelete(id);
        }


    }
}
