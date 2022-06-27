using News.Core.DTOs.Blogs;
using News.DataLayer.Entities.Blog;

namespace News.Core.Services.Interfaces
{
    public interface IBlogCommentService
    {
        BlogCommentsViewModel GetBlogComments(int pageId, int take, int blogId);
        BlogComment GetCommentById(int commentId);
        void DeleteComment(BlogComment comment);
        BlogComment AddComment(BlogComment comment);
        void EditComment(BlogComment comment);
    }
}