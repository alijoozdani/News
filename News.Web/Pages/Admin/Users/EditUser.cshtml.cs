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
    [PermissionChecker(4)]
    public class EditUserModel : PageModel
    {
        private IUserService _userService;
        private IPermissionService _permissionService;
        public EditUserModel(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }
        [BindProperty]
        public EditUserForAdminViewModel UserModel { get; set; }
        public void OnGet(int id)
        {
            UserModel = _userService.GetUserForEdit(id);
            ViewData["Rols"] = _permissionService.GetRols();
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Rols"] = _permissionService.GetRols();
                return Page();
            }

            _userService.EditUserForAdmin(UserModel);
            _permissionService.EditRolesUser(SelectedRoles, UserModel.UserId);

            return RedirectToPage("Index");
        }
    }
}
