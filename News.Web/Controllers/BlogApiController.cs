using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogApiController : ControllerBase
    {
        private NewsContext _context;
        public BlogApiController(NewsContext context)
        {
            _context = context;
        }
        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var blogTitle = _context.Blogs
                    .Where(b => b.Title.Contains(term))
                    .Select(b => b.Title)
                    .ToList();
                return Ok(blogTitle);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
