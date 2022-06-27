using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News.Core.Services.Interfaces;
using News.DataLayer.Entities.Blog;

namespace News.Web.Pages.Admin.Categories
{
    public class AddModel : PageModel
    {
        private IGroupService _groupService;
        public AddModel(IGroupService groupService)
        {
            _groupService = groupService;
        }
        [BindProperty]
        public BlogGroup BlogGroup { get; set; }
        public void OnGet(int? id)
        {
            BlogGroup = new BlogGroup()
            {
                ParentId = id
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _groupService.AddGroup(BlogGroup);
            return RedirectToPage("Index");
        }
    }
}
