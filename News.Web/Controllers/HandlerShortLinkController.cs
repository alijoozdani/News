using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using News.Core.Services.Interfaces;

namespace News.Web.Controllers
{
    public class HandlerShortLinkController : Controller
    {
        private IBlogService _blog;

        public HandlerShortLinkController(IBlogService blog)
        {
            _blog = blog;
        }
        [Route("/b/{shortLink}")]
        public IActionResult HandlerBlogShortLink(string shortLink)
        {
            var blog = _blog.GetBlog(shortLink);
            if (blog == null)
            {
                return NotFound();
            }
            var host = Request.Host;
            var path = $"/ShowBlog/{blog.BlogId}";
            path = String.Join(
                "/",
                path.Split("/").Select(s => System.Net.WebUtility.UrlEncode(s))
            );

            return Redirect($"https://{host}{path}");
        }
    }
}