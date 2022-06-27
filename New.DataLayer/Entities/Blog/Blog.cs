using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace News.DataLayer.Entities.Blog
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        [Display(Name = "دسته بندی")]
        [Required]
        public int GroupId { get; set; }

        public int? SubGroup { get; set; }

        [Display(Name = "عنوان بلاگ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(400)]
        public string Title { get; set; }

        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.MultilineText)]
        public string ShortDescription { get; set; }
        public string ShortLink { get; set; }

        [Display(Name = "متن کامل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.MultilineText)]
        public string BlogText { get; set; }

        [Display(Name = "کلمات کلیدی")]
        public string Tags { get; set; }

        [Display(Name = "تصویر")]
        public string ImageName { get; set; }

        [Display(Name = "بازدید")]
        public int BlogVisit { get; set; }

        [Display(Name = "تاریخ ساخت")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "خبر ویژه")]
        public bool IsSpecial { get; set; }
        public bool IsDelete { get; set; }


        #region Relation
        [ForeignKey("GroupId")]
        public BlogGroup BlogGroup { get; set; }

        [ForeignKey("SubGroup")]
        public BlogGroup Group { get; set; }

        public List<BlogComment> BlogComments { get; set; }

        #endregion
    }
}
