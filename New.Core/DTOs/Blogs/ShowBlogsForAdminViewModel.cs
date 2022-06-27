using News.DataLayer.Entities.Blog;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Core.DTOs.Blogs
{
    public class ShowBlogsForAdminViewModel
    {
        public List<Blog> Blogs { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }
    }
}
