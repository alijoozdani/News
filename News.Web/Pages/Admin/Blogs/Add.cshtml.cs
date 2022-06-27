using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using News.Core.Security;
using News.Core.Senders;
using News.Core.Services.Interfaces;
using News.DataLayer.Entities.Blog;

namespace News.Web.Pages.Admin.Blogs
{
    [PermissionChecker(9)]
    public class AddModel : PageModel
    {
        private IGroupService _groupService;
        private IBlogService _blogService;
        private IUserService _userService;
        public AddModel(IGroupService groupService,IBlogService blogService, IUserService userService)
        {
            _groupService = groupService;
            _blogService = blogService;
            _userService = userService;
        }
        [BindProperty]
        public Blog Blog { get; set; }
        public void OnGet()
        {
            var groups = _groupService.GetGroupForManager();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");

            var subGroups = _groupService.GetSubGroupForManager(int.Parse(groups.First().Value));
            ViewData["SubGroups"] = new SelectList(subGroups, "Value", "Text");
        }

        public IActionResult OnPost(IFormFile imgUpBlog)
        {
            if (!ModelState.IsValid)
            {
                var groups = _groupService.GetGroupForManager();
                ViewData["Groups"] = new SelectList(groups, "Value", "Text");

                var subGroups = _groupService.GetSubGroupForManager(int.Parse(groups.First().Value));
                ViewData["SubGroups"] = new SelectList(subGroups, "Value", "Text");
                return Page();
            }

            
            _blogService.AddBLog(Blog,imgUpBlog);

            if (Blog.IsSpecial)
            {
                var body=EmailTemplate.BuildView(Blog.BlogText);
                _userService.SendNewsToRss(body);
            }

            return RedirectToPage("Index");
        }
    }
}
