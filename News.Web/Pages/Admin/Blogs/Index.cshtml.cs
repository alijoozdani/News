using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News.Core.DTOs.Blogs;
using News.Core.Security;
using News.Core.Services.Interfaces;

namespace News.Web.Pages.Admin.Blogs
{
    [PermissionChecker(8)]
    public class IndexModel : PageModel
    {
        private IBlogService _blogService;
        public IndexModel(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public ShowBlogsForAdminViewModel Blogs { get; set; }
        public void OnGet(int pageId=1,string search = "", string groupTitle="")
        {
            Blogs = _blogService.GetBlogsForAdmin(pageId, search, groupTitle);
        }

        public IActionResult OnGetDeleteBLog(int blogId)
        {
            bool result = _blogService.DeleteBlog(blogId);
            if (result == false)
            {
                return Content("NotFound");
            }
            return Content("Deleted");
        }
    }
}
