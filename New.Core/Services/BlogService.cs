using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using News.Core.Convertor;
using News.Core.DTOs;
using News.Core.DTOs.Blogs;
using News.Core.Generator;
using News.Core.Security;
using News.Core.Services.Interfaces;
using News.DataLayer.Context;
using News.DataLayer.Entities.Blog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace News.Core.Services
{
    public class BlogService : IBlogService
    {
        private NewsContext _context;
        public BlogService(NewsContext context)
        {
            _context = context;
        }
        public void AddBLog(Blog blog, IFormFile imgBlog)
        {
            blog.ShortLink = GenerateShortKey(4);
            blog.CreateDate = DateTime.Now;
            blog.ImageName = "no-photo.png";

            if (imgBlog != null && imgBlog.IsImage())
            {
                blog.ImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(imgBlog.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/blog", blog.ImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgBlog.CopyTo(stream);
                }

                ImageConvertor imgResizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/blog/thumb", blog.ImageName);

                imgResizer.Image_resize(imagePath, thumbPath, 242);
            }
            _context.Add(blog);
            _context.SaveChanges();
        }

        public bool DeleteBlog(int blogId)
        {
            var blog = GetBlogById(blogId);
            blog.IsDelete = true;

            _context.Update(blog);
            _context.SaveChanges();
            return true;
        }

        public Blog GetBlogById(int blogId)
        {
            return _context.Blogs.Find(blogId);
        }

        public ShowBlogsForAdminViewModel GetBlogsForAdmin(int pageId, string search, string groupTitle)
        {
            IQueryable<Blog> result = _context.Blogs.Include(b=>b.BlogGroup);
            if (!string.IsNullOrEmpty(search))
            {
                result = result.Where(b => b.Title.Contains(search) || b.Tags.Contains(search));
            }
            if (!string.IsNullOrEmpty(groupTitle))
            {
                result = result.Where(b => b.BlogGroup.GroupName == groupTitle);
            }

            int take = 20;
            int skip = (pageId - 1) * take;
            int pageCount = result.Count()/take;

            ShowBlogsForAdminViewModel list = new ShowBlogsForAdminViewModel()
            {
                Blogs = result.Skip(skip).Take(take).ToList(),
                CurrentPage = pageId,
                StartPage = (pageId - 4 <= 0) ? 1 : pageId - 4,
                EndPage = (pageId + 5 > pageCount) ? pageCount : pageId + 5,
                PageCount = pageCount
            };

            return list;
        }

        public void EditBlog(Blog blog, IFormFile imgBlog)
        {
            if (imgBlog != null && imgBlog.IsImage())
            {
                if (blog.ImageName != "no-photo.png")
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/blog", blog.ImageName);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                    string deletethumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/blog/thumb", blog.ImageName);
                    if (File.Exists(deletethumbPath))
                    {
                        File.Delete(deletethumbPath);
                    }
                }
                blog.ImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(imgBlog.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/blog", blog.ImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgBlog.CopyTo(stream);
                }

                ImageConvertor imgResizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/blog/thumb", blog.ImageName);

                imgResizer.Image_resize(imagePath, thumbPath, 242);
            }
            _context.Update(blog);
            _context.SaveChanges();
        }

        public List<ShowBlogsListItemViewModel> GetBlogs(int groupId,int take, string filter="", string orderBy = "all")
        {
            if (take == 0)
                take = 10;

            IQueryable<Blog> result = _context.Blogs;

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(b => b.Title.Contains(filter) || b.Tags.Contains(filter));
            }

            if (groupId != 0)
            {
                result = result.Where(b => b.GroupId == groupId || b.SubGroup==groupId);
            }

            switch (orderBy)
            {
                case "date":
                    {
                        result = result.OrderByDescending(b => b.CreateDate);
                        break;
                    }
                case "visit":
                    {
                        result = result.OrderByDescending(b => b.BlogVisit);
                        break;
                    }
                case "comment":
                    {
                        result = result.Include(b => b.BlogComments).OrderByDescending(b => b.BlogComments.Count());
                        break;
                    }
            }

            

            var query = result.Include(b => b.BlogGroup).Select(b => new ShowBlogsListItemViewModel()
            {
                BlogId = b.BlogId,
                BlogName = b.Title,
                CreateDate = b.CreateDate,
                ShortDescription = b.ShortDescription,
                ImageName = b.ImageName,
                GroupTitle = b.BlogGroup.GroupName
            }).Take(take).ToList();

            return query;
        }

        public Blog GetBlogForShow(int blogId)
        {
            return _context.Blogs.Include(b => b.BlogGroup).FirstOrDefault(b => b.BlogId == blogId);
        }

        public List<ShowBlogsListItemViewModel> GetSpetialBlogs()
        {
            return _context.Blogs.Include(b=>b.BlogGroup).Where(b => b.IsSpecial).Select(b=> new ShowBlogsListItemViewModel() 
            { 
            BlogId=b.BlogId,
            BlogName=b.Title,
            CreateDate=b.CreateDate,
            ImageName=b.ImageName,
            ShortDescription=b.ShortDescription,
            GroupTitle=b.BlogGroup.GroupName
            }).ToList();
        }

        public List<GalleryViewModel> GetGalleryImage()
        {
            return _context.Blogs.Take(4).Select(b => new GalleryViewModel()
            {
                BlogId = b.BlogId,
                ImageName = b.ImageName
            }).ToList();
        }

        public List<HotBLogViewModel> GetHotBlog()
        {
            return _context.Blogs.Include(b => b.BlogComments).OrderByDescending(b => b.BlogComments.Count())
                .Select(b => new HotBLogViewModel()
                {
                    BlogId = b.BlogId,
                    BlogTitle = b.Title
                }).Take(10).ToList();
        }

        public void AddVisit(int blogId)
        {
            var blog = GetBlogById(blogId);
            blog.BlogVisit += 1;
            _context.Update(blog);
            _context.SaveChanges();
        }

        public Blog GetBlog(string shortLink)
        {
            return _context.Blogs.SingleOrDefault(b => b.ShortLink == shortLink);
        }

        private string GenerateShortKey(int length)
        {
            //در این جا یک کلید با طول دلخواه تولید میکنیم
            var key = Guid.NewGuid().ToString().Replace("-", "").Substring(0, length);

            while (GetBlog(key) != null)
            {
                //تا زمانی که کلید ساخته شده تکراری باشد این اعملیات تکرار میشود

                key = Guid.NewGuid().ToString().Replace("-", "").Substring(0, length);
            }
            //در آخر یک کلید غیره تکراری با طول دلخواه ساخته شده
            return key;
        }
    }
}
