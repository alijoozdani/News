using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News.Core.Security;
using News.Core.Services.Interfaces;
using News.DataLayer.Entities.Blog;

namespace News.Web.Pages.Admin.Categories
{
    [PermissionChecker(11)]
    public class IndexModel : PageModel
    {
        private IGroupService _groupService;
        public IndexModel(IGroupService groupService)
        {
            _groupService = groupService;
        }
        public List<BlogGroup> BlogGroups { get; set; }
        public void OnGet()
        {
            BlogGroups = _groupService.GetAllGorups();
        }

        public IActionResult OnGetDeleteGroup(int groupId)
        {
            var res = _groupService.DeleteGroup(groupId);
            return res ? Content("Deleted") : Content("Error");
        }
    }
}
