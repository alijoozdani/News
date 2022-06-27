using Microsoft.AspNetCore.Http;
using News.Core.DTOs;
using News.Core.DTOs.Blogs;
using News.DataLayer.Entities.Blog;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Core.Services.Interfaces
{
    public interface IBlogService
    {
        ShowBlogsForAdminViewModel GetBlogsForAdmin(int pageId, string search, string groupTitle);
        List<ShowBlogsListItemViewModel> GetBlogs(int groupId, int take, string filter="", string orderBy="all");
        List<ShowBlogsListItemViewModel> GetSpetialBlogs();
        List<HotBLogViewModel> GetHotBlog();
        Blog GetBlogById(int blogId);
        Blog GetBlogForShow(int blogId);
        Blog GetBlog(string shortLink);
        void AddBLog(Blog blog, IFormFile imgBlog);
        void EditBlog(Blog blog, IFormFile imgBlog);
        void AddVisit(int blogId);
        bool DeleteBlog(int blogId);

        #region Gallery
        List<GalleryViewModel> GetGalleryImage();
        #endregion
    }
}
