
using News.DataLayer.Entities.Permissions;
using News.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Core.Services.Interfaces
{
    public interface IPermissionService
    {
        #region Roles
        List<Role> GetRols();
        void AddRolesToUser(List<int> roleIds, int userId);
        void EditRolesUser(List<int> roleIds, int userId);
        int AddRole(Role role);
        Role GetRoleById(int roleId);
        void UpdateRole(Role role);
        bool DeleteRole(int roleId);
        #endregion

        #region Permissions
        List<Permission> GetAllPermissions();
        void AddPermissionToRole(int roleId, List<int> permission);
        List<int> PermissionRole(int roleId);
        void UpdatePermissionsRole(int roleId, List<int> permission);
        bool CheckPermission(int permissionId, int userId);
        #endregion
    }
}
