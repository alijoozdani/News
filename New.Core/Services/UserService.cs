using Microsoft.EntityFrameworkCore;
using News.Core.Convertor;
using News.Core.DTOs;
using News.Core.Generator;
using News.Core.Security;
using News.Core.Senders;
using News.Core.Services.Interfaces;
using News.DataLayer.Context;
using News.DataLayer.Entities.RSS;
using News.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace News.Core.Services
{
    public class UserService : IUserService
    {
        private NewsContext _context;
        public UserService(NewsContext context)
        {
            _context = context;
        }

        public bool ActiveAccount(string activeCode)
        {
            var user = _context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
            if (user == null || user.IsActive)
            {
                return false;
            }
            user.IsActive = true;
            user.ActiveCode = NameGenerator.GenerateUniqCode();
            _context.SaveChanges();

            return true;
        }

        public bool AddEmailToRss(RSS rss)
        {
            _context.RSS.Add(rss);
            _context.SaveChanges();
            return true;
        }

        public int AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.UserId;
        }

        public int AddUserForAdmin(AddUserForAdminViewMdel user)
        {
            User addUser = new User();
            addUser.Password = PasswordHelper.EncodePasswordMd5(user.Password);
            addUser.UserName = user.UserName;
            addUser.IsActive = user.IsActive;
            addUser.Email = user.Email;
            addUser.ActiveCode = NameGenerator.GenerateUniqCode();
            addUser.RegisterDate = DateTime.Now;
            return AddUser(addUser);
        }



        public bool CompareOldPassword(int userId, string oldPassword)
        {
            string hashPassword = PasswordHelper.EncodePasswordMd5(oldPassword);
            return _context.Users.Any(u => u.UserId == userId && u.Password == hashPassword);
        }

        public bool DeleteUser(int userId)
        {
            var user = GetUserById(userId);
            user.IsDelete = true;
            UpdateUser(user);
            return true;
        }



        public void EditUserForAdmin(EditUserForAdminViewModel editUser)
        {
            User user = GetUserById(editUser.UserId);
            user.Email = editUser.Email;
            user.UserName = editUser.UserName;
            user.IsActive = editUser.IsActive;

            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public IEnumerable<string> GetEmailsRss()
        {
            return _context.RSS.Select(e => e.EmailAddress).ToList();
        }

        public User GetUserByActiveCode(string activeCode)
        {
            return _context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.SingleOrDefault(u => u.Email == email);
        }

        public User GetUserById(int userId)
        {
            return _context.Users.SingleOrDefault(u => u.UserId == userId);
        }

        public EditUserForAdminViewModel GetUserForEdit(int userId)
        {
            return _context.Users.Where(u => u.UserId == userId).Select(u => new EditUserForAdminViewModel()
            {
                UserId = userId,
                UserName = u.UserName,
                Email = u.Email,
                IsActive = u.IsActive,
                UserRoles = u.UserRoles.Select(r => r.RoleId).ToList(),
            }).Single();
        }

        public UserForAdminViewModel GetUsersForAdmin(int pageId = 1, string filter = "")
        {
            IQueryable<User> result = _context.Users;

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(u => u.Email.Contains(filter) || u.UserName.Contains(filter));
            }

            //sho item in page
            int take = 20;
            int skip = (pageId - 1) * take;
            int pageCount = result.Count() / take;
            UserForAdminViewModel list = new UserForAdminViewModel()
            {
                CurrentPage = pageId,
                PageCount = pageCount,
                StartPage = (pageId - 4 <= 0) ? 1 : pageId - 4,
                EndPage = (pageId + 5 > pageCount) ? pageCount : pageId + 5,
                Users = result.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList()
            };
            return list;
        }



        public bool IsExistEmail(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }

        public bool IsExistEmailInRss(string email)
        {
            return _context.RSS.Any(e => e.EmailAddress == email);
        }

        public bool IsExistUserName(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }

        public bool IsUserAdmin(string userName)
        {
            return _context.Users.Include(u => u.UserRoles).FirstOrDefault(u => u.UserName == userName).UserRoles.Any(r => r.RoleId == 1);
        }

        public User LoginUser(LoginViewModel login)
        {
            string hashPassword = PasswordHelper.EncodePasswordMd5(login.Password);
            string email = FixedText.FixedEmail(login.Email);
            return _context.Users.SingleOrDefault(u => u.Email == email && u.Password == hashPassword);

        }

        public bool SendNewsToRss(string body)
        {
            if (body != null)
            {
                try
                {
                    var Emails = GetEmailsRss();
                    foreach (var item in Emails)
                    {
                        SendEmail.Send(item, "اخبار ویژه وبسایت روبین وب", body);
                        System.Threading.Thread.Sleep(3000);
                    }
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
