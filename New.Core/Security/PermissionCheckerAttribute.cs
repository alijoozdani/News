using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;
using News.Core.Services.Interfaces;
using System.Security.Claims;

namespace News.Core.Security
{
    public class PermissionCheckerAttribute: AuthorizeAttribute, IAuthorizationFilter
    {
        private IPermissionService _permissionService;
        private int _permissionId = 0;
        public PermissionCheckerAttribute(int permissionId)
        {
            _permissionId = permissionId;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _permissionService =
                (IPermissionService)context.HttpContext.RequestServices.GetService(typeof(IPermissionService));

            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                int userId = int.Parse(context.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)
                    .Value);

                if (!_permissionService.CheckPermission(_permissionId, userId))
                {
                    context.Result = new RedirectResult("/Login");
                }
            }
            else
            {
                context.Result = new RedirectResult("/Login?" + context.HttpContext.Request.Path);
            }
        }
    }
}
