using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using News.Core.Security;
using News.Core.Services.Interfaces;
using News.DataLayer.Entities.Blog;

namespace News.Web.Pages.Admin.Blogs
{
    [PermissionChecker(10)]
    public class EditModel : PageModel
    {
        private IGroupService _groupService;
        private IBlogService _blogService;
        public EditModel(IGroupService groupService, IBlogService blogService)
        {
            _groupService = groupService;
            _blogService = blogService;
        }
        [BindProperty]
        public Blog Blog { get; set; }
        public void OnGet(int id)
        {
            Blog = _blogService.GetBlogById(id);

            var groups = _groupService.GetGroupForManager();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");

            var subGroups = _groupService.GetSubGroupForManager(Blog.GroupId);
            ViewData["SubGroups"] = new SelectList(subGroups, "Value", "Text");
        }

        public IActionResult OnPost(IFormFile imgUpBlog)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _blogService.EditBlog(Blog, imgUpBlog);

            return RedirectToPage("Index");
        }
    }
}
