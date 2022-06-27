using System;
using System.Collections.Generic;
using System.Text;

namespace News.Core.DTOs.Blogs
{
    public class ShowBlogsListItemViewModel
    {
        public int BlogId { get; set; }
        public string GroupTitle { get; set; }
        public DateTime CreateDate { get; set; }
        public string BlogName { get; set; }
        public string ShortDescription { get; set; }
        public string ImageName { get; set; }
    }
}
