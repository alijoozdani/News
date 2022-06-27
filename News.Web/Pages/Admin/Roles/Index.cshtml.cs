using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News.Core.Security;
using News.Core.Services.Interfaces;
using News.DataLayer.Entities.User;

namespace News.Web.Pages.Admin.Roles
{
    [PermissionChecker(5)]
    public class IndexModel : PageModel
    {
        private IPermissionService _permissionService;
        public IndexModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        public List<Role> Roles { get; set; }
        public void OnGet()
        {
            Roles = _permissionService.GetRols();
        }
        public IActionResult OnGetDeleteRole(int roleId)
        {
            var res = _permissionService.DeleteRole(roleId);
            return res ? Content("Deleted") : Content("Error");
        }
    }
}
