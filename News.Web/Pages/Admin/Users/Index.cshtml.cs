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
    [PermissionChecker(2)]
    public class IndexModel : PageModel
    {
        private IUserService _userService;
        public IndexModel(IUserService userService)
        {
            _userService = userService;
        }

        public UserForAdminViewModel UsersModel { get; set; }
        public void OnGet(int pageId=1,string filter="")
        {
            UsersModel = _userService.GetUsersForAdmin(pageId,filter);
        }

        public IActionResult OnGetDeleteUser(int userId)
        {
            var res = _userService.DeleteUser(userId);
            return res ? Content("Deleted") : Content("Error");
        }
    }
}
