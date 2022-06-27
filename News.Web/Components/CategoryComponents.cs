using Microsoft.AspNetCore.Mvc;
using News.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace News.Web.Components
{
    public class CategoryComponents:ViewComponent
    {
        private IGroupService _groupService;
        public CategoryComponents(IGroupService groupService)
        {
            _groupService = groupService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("CategoryBlogs", _groupService.GetAllGorups()));
        }
    }
}
