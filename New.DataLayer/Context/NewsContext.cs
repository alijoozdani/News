using Microsoft.EntityFrameworkCore;
using News.DataLayer.Entities.AboutUs;
using News.DataLayer.Entities.Blog;
using News.DataLayer.Entities.ContactUs;
using News.DataLayer.Entities.Permissions;
using News.DataLayer.Entities.RSS;
using News.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.DataLayer.Context
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options) : base(options)
        {

        }

        #region Blog
        public DbSet<BlogGroup> BlogGroups { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        #endregion

        #region User
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        #endregion

        #region Perimissions
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        #endregion
        #region Content
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<ContactUsForm> ContactUsForms { get; set; }
        public DbSet<RSS> RSS { get; set; }
        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasQueryFilter(u => !u.IsDelete);
            modelBuilder.Entity<Role>()
                .HasQueryFilter(r => !r.IsDelete);
            modelBuilder.Entity<Blog>()
                .HasQueryFilter(b => !b.IsDelete)
                .HasOne<BlogGroup>(g => g.Group).WithMany(g => g.SubGroup).HasForeignKey(g => g.SubGroup);
            modelBuilder.Entity<BlogGroup>()
                .HasQueryFilter(b => !b.IsDelete);
            modelBuilder.Entity<BlogComment>()
                .HasQueryFilter(b => !b.IsDelete);

            base.OnModelCreating(modelBuilder);
        }
    }
}
