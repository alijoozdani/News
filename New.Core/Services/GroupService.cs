using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using News.Core.Services.Interfaces;
using News.DataLayer.Context;
using News.DataLayer.Entities.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace News.Core.Services
{
    public class GroupService:IGroupService
    {
        private NewsContext _context;
        public GroupService(NewsContext context)
        {
            _context = context;
        }

        public void AddGroup(BlogGroup group)
        {
            _context.BlogGroups.Add(group);
            _context.SaveChanges();
        }

        public List<BlogGroup> GetAllGorups()
        {
            return _context.BlogGroups.ToList();
        }

        public BlogGroup GetGroupById(int groupId)
        {
            return _context.BlogGroups.Find(groupId);
        }

        public List<SelectListItem> GetGroupForManager()
        {
            return _context.BlogGroups.Where(g=>g.ParentId==null)
                .Select(c => new SelectListItem()
                {
                    Text = c.GroupName,
                    Value = c.GroupId.ToString()
                }).ToList();
        }

        public List<BlogGroup> GetSubGroups(int groupId)
        {
            return _context.BlogGroups.Where(g => g.ParentId == groupId).ToList();
        }

        public List<SelectListItem> GetSubGroupForManager(int groupId)
        {
            return _context.BlogGroups.Where(g => g.ParentId == groupId)
                .Select(g => new SelectListItem()
                {
                    Text = g.GroupName,
                    Value = g.GroupId.ToString()
                }).ToList();
        }

        public void UpdateGroup(BlogGroup group)
        {
            _context.BlogGroups.Update(group);
            _context.SaveChanges();
        }

        public bool DeleteGroup(int groupId)
        {
            var group = GetGroupById(groupId);
            group.IsDelete = true;
            _context.SaveChanges();
            return true;
        }

        public string GetGroupTitle(int groupId)
        {
            return _context.BlogGroups.First(g => g.GroupId == groupId).GroupName;
        }
    }
}
 