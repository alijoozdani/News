using Microsoft.AspNetCore.Mvc;
using News.Core.Convertor;
using News.Core.Services.Interfaces;
using News.Core.Utilities;
using News.DataLayer.Entities.Blog;
using System;
using System.Collections.Generic;
using System.Linq;


namespace News.Web.Controllers
{
    public class BlogController : Controller
    {
        private IBlogService _blogService;
        private IBlogCommentService _comment;
        private IGroupService _groupService;
        public BlogController(IBlogService blogService, IBlogCommentService comment,IGroupService groupService)
        {
            _blogService = blogService;
            _comment = comment;
            _groupService = groupService;
        }
        //[Route("Blogs/{groupId}/{filter}")]
        public IActionResult Index(int groupId,int take=10, string filter = "")
        {
            ViewData["Take"] = take;
            ViewData["GroupId"] = groupId;
            if (groupId != 0)
            {
                ViewData["GroupTitle"] = _groupService.GetGroupTitle(groupId);
                ViewBag.GroupId = groupId;
            }
            else
            {
                ViewData["GroupTitle"] = "نتایج جستوجو";
            }
            
            return View(_blogService.GetBlogs(groupId, take,filter));
        }
        [Route("ShowBlog/{id}")]
        public IActionResult ShowBlog(int id)
        {
            //var ip = GetLocalIpAddress.GetLocalIPAddress();
            var blog = _blogService.GetBlogForShow(id);
            _blogService.AddVisit(id);
            //پر کردن اولیه بخش نظرات
           
            ViewData["Comments"] = _comment.GetBlogComments(1, 5, blog.BlogId);
            return View(blog);
        }
        public IActionResult GetBlogComments(int pageId, int blogId)
        {
            var blogComments = _comment.GetBlogComments(pageId, 10, blogId);
            if (blogComments.BlogComments == null)
            {
                return NotFound();
            }
            return PartialView("Blog/_BlogComments", blogComments);
        }

        [HttpPost]
        public IActionResult AddComment(BlogComment blogComment)
        {

            if (string.IsNullOrEmpty(blogComment.Comment))
            {
                return Content("Error");
            }
            var resultComment = _comment.AddComment(blogComment);
            var userName = $"{resultComment.Name} {resultComment.Email}";
            var res = $"<div class='comment-box'><div class='img-layer'></div><div class='left'><span>{userName}</span><i>ارسال شده در {resultComment.CreateDate.ToShamsi()}</i><p>{blogComment.Comment}</p></div></div>";
            //اگر این نظر یک پاسخ برای یک نظر دیگه باشد وارد شرط میشه و بعد سمت کلاینت صفحه را رفرش میکنیم
            if (blogComment.Answer != null)
            {
                return Content("Success");
            }
            return Content(res);
        }

        public IActionResult DeleteComment(int commentId, int blogId)
        {

            var comment = _comment.GetCommentById(commentId);
            if (comment != null)
            {
                if (comment.BlogId == blogId)
                {
                    _comment.DeleteComment(comment);
                    return Content("Deleted");
                }

            }
            return Content("Error");

        }
    }
}
