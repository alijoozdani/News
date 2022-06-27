using News.Core.DTOs;
using News.DataLayer.Entities.RSS;
using News.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Core.Services.Interfaces
{
    public interface IUserService
    {
        bool IsExistUserName(string userName);
        bool IsExistEmail(string email);
        int AddUser(User user);
        User LoginUser(LoginViewModel login);
        User GetUserByEmail(string email);
        User GetUserByActiveCode(string activeCode);
        User GetUserById(int userId);
        void UpdateUser(User user);
        bool ActiveAccount(string activeCode);
        bool IsUserAdmin(string userName);


        #region Admin Panel
        public UserForAdminViewModel GetUsersForAdmin(int pageId = 1, string filter = "");
        int AddUserForAdmin(AddUserForAdminViewMdel user);
        EditUserForAdminViewModel GetUserForEdit(int userId);
        void EditUserForAdmin(EditUserForAdminViewModel editUser);
        bool DeleteUser(int userId);
        #endregion

        #region Rss
        bool AddEmailToRss(RSS rss);
        bool IsExistEmailInRss(string email);
        IEnumerable<string> GetEmailsRss();
        bool SendNewsToRss(string body);
        #endregion
    }
}
