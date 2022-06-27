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
    [PermissionChecker(6)]
    public class AddRoleModel : PageModel
    {
        private IPermissionService _permissionService;
        public AddRoleModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [BindProperty]
        public Role Role { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost(List<int> permissions)
        {
            if (!ModelState.IsValid)
                return Page();

            Role.IsDelete = false;
            int roleId=_permissionService.AddRole(Role);

            // AddPermission to role
            _permissionService.AddPermissionToRole(roleId, permissions);

            return RedirectToPage("Index");
        }
    }
}
