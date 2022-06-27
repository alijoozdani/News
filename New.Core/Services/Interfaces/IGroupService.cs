using Microsoft.AspNetCore.Mvc.Rendering;
using News.DataLayer.Entities.Blog;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Core.Services.Interfaces
{
    public interface IGroupService
    {
        #region Categories
        List<BlogGroup> GetAllGorups();
        List<BlogGroup> GetSubGroups(int groupId);
        List<SelectListItem> GetGroupForManager();
        List<SelectListItem> GetSubGroupForManager(int groupId);
        BlogGroup GetGroupById(int groupId);
        void AddGroup(BlogGroup group);
        void UpdateGroup(BlogGroup group);
        bool DeleteGroup(int groupId);
        string GetGroupTitle(int groupId);
        #endregion
    }
}
