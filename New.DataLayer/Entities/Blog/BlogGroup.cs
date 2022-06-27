using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace News.DataLayer.Entities.Blog
{
    public class BlogGroup
    {
        [Key]
        public int GroupId { get; set; }

        [Display(Name = "گروه اصلی")]
        public int? ParentId { get; set; }

        [Display(Name ="عنوان گروه")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(200)]
        public string GroupName { get; set; }
        public bool IsDelete { get; set; }

        #region Relation
        [ForeignKey("ParentId")]
        public List<BlogGroup> BlogGroups { get; set; }

        [InverseProperty("BlogGroup")]
        public List<Blog> Blogs { get; set; }

        [InverseProperty("Group")]
        public List<Blog> SubGroup { get; set; }
        #endregion
    }
}
