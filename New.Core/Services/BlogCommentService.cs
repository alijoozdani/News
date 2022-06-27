using News.Core.DTOs.Blogs;
using News.Core.Services.Interfaces;
using News.DataLayer.Context;
using News.DataLayer.Entities.Blog;
using System;
using System.Linq;
namespace News.Core.Services
{
    public class BlogCommentService : IBlogCommentService
    {
        private NewsContext _context;

        public BlogCommentService(NewsContext context)
        {
            _context = context;
        }

        public BlogComment AddComment(BlogComment comment)
        {
            comment.CreateDate = DateTime.Now;
            _context.BlogComments.Add(comment);
            _context.SaveChanges();
            return GetCommentById(comment.CommentId);
        }

        public void DeleteComment(BlogComment comment)
        {
            comment.IsDelete = true;
            _context.Update(comment);
            _context.SaveChanges();
        }

        public void EditComment(BlogComment comment)
        {
            _context.Update(comment);
            _context.SaveChanges();
        }

        public BlogComment GetCommentById(int commentId)
        {
            return _context.BlogComments.Find(commentId);
        }

        public BlogCommentsViewModel GetBlogComments(int pageId, int take, int blogId)
        {
            var comments = _context.BlogComments.Where(c=>c.BlogId==blogId);
            var mainComments = comments.Where(c => c.Answer == null).OrderByDescending(c => c.CreateDate);
            var answerComments = comments.Where(c => c.Answer != null);
            var skip = (pageId - 1) * take;
            var pageCount = (int)Math.Ceiling(mainComments.Count() / (double)take);
            var commentsModel = new BlogCommentsViewModel()
            {
                BlogComments = mainComments.Skip(skip).Take(take).ToList(),
                AnswerComments = answerComments.ToList(),
                CurrentPage = pageId,
                PageCount = pageCount,
                StartPage = (pageId - 4 <= 0) ? 1 : pageId - 4,
                EndPage = (pageId + 5 > pageCount) ? pageCount : pageId + 5,
                CommentsCount = comments.Count()
            };
            return commentsModel;
        }
    }
}