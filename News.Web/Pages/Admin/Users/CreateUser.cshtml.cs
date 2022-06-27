using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using News.Core.DTOs;
using News.Core.Security;
using News.Core.Services.Interfaces;

namespace News.Web.Pages.Admin.Users
{
    [PermissionChecker(3)]
    public class CreateUserModel : PageModel
    {
        private IUserService _userService;
        private IPermissionService _permissionService;
        public CreateUserModel(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }
        [BindProperty]
        public AddUserForAdminViewMdel UserModel { get; set; }
        public void OnGet()
        {
            ViewData["Rols"] = _permissionService.GetRols();
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Rols"] = _permissionService.GetRols();
                return Page();
            }

            int userId = _userService.AddUserForAdmin(UserModel);

            _permissionService.AddRolesToUser(SelectedRoles, userId);

            return Redirect("/Admin/Users");
        }
    }
}
