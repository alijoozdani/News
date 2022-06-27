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
    [PermissionChecker(7)]
    public class EditRoleModel : PageModel
    {
        private IPermissionService _permissionService;
        public EditRoleModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        [BindProperty]
        public Role Role { get; set; }
        public void OnGet(int id)
        {
            Role = _permissionService.GetRoleById(id);
            if (Role == null)
            {
                Response.Redirect("/Admin/Roles");
            }
        }
        public IActionResult OnPost(List<int> permissions)
        {
            if (!ModelState.IsValid)
                return Page();


            _permissionService.UpdateRole(Role);

            // Add new Permissions
            _permissionService.UpdatePermissionsRole(Role.RoleId, permissions);

            return RedirectToPage("Index");
        }
    }
}
