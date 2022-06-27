using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace News.DataLayer.Entities.Blog
{
    public class BlogComment
    {
        [Key]
        public int CommentId { get; set; }
        public int BlogId { get; set; }

        [Display(Name = "نام شما")]
        [Required(ErrorMessage = "لطفا نام خود را بنویسید")]
        [MaxLength(150)]
        public string Name { get; set; }

        [Display(Name = "ایمیل  شما")]
        [Required(ErrorMessage = "لطفا ایمیلتان را بنویسید")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "دیدگاه شما")]
        [Required(ErrorMessage = "لطفا دیدگاهتان را بنویسید")]
        [MaxLength(700)]
        public string Comment { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
        public int? Answer { get; set; }

        #region Relation
        public Blog Blog { get; set; }
        #endregion
    }
}
