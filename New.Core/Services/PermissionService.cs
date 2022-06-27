using News.Core.Services.Interfaces;
using News.DataLayer.Context;
using News.DataLayer.Entities.Permissions;
using News.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace News.Core.Services
{
    public class PermissionService : IPermissionService
    {
        private NewsContext _context;
        public PermissionService(NewsContext context)
        {
            _context = context;
        }

        public void AddPermissionToRole(int roleId, List<int> permission)
        {
            foreach(var item in permission)
            {
                _context.RolePermissions.Add(new RolePermission()
                {
                    RoleId = roleId,
                    PermissionId = item
                });
            }
            _context.SaveChanges();
        }

        public int AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role.RoleId;
        }

        public void AddRolesToUser(List<int> roleIds, int userId)
        {
            foreach(var roleId in roleIds)
            {
                _context.UserRoles.Add(new UserRole()
                {
                    RoleId = roleId,
                    UserId = userId
                });
            }
            _context.SaveChanges();
        }

        public bool CheckPermission(int permissionId, int userId)
        {
            List<int> UserRoles = _context.UserRoles.Where(r => r.UserId == userId)
                .Select(r => r.RoleId).ToList();

            if (!UserRoles.Any())
                return false;

            List<int> RolePermission = _context.RolePermissions.Where(p => p.PermissionId == permissionId)
                .Select(p => p.RoleId).ToList();

            return RolePermission.Any(p => UserRoles.Contains(p));
        }

        public bool DeleteRole(int roleId)
        {
            var role = GetRoleById(roleId);
            role.IsDelete = true;
            UpdateRole(role);
            return true;
        }

        public void EditRolesUser(List<int> roleIds, int userId)
        {
            //Delete User Roles
            _context.UserRoles.Where(r => r.UserId == userId).ToList().ForEach(r =>
                _context.UserRoles.Remove(r));

            //Add New Roles
            AddRolesToUser(roleIds,userId);
        }

        public List<Permission> GetAllPermissions()
        {
            return _context.Permissions.ToList();
        }

        public Role GetRoleById(int roleId)
        {
            return _context.Roles.Find(roleId);
        }

        public List<Role> GetRols()
        {
            return _context.Roles.ToList();
        }

        public List<int> PermissionRole(int roleId)
        {
            return _context.RolePermissions.Where(r => r.RoleId == roleId)
                .Select(p => p.PermissionId).ToList();
        }

        public void UpdatePermissionsRole(int roleId, List<int> permission)
        {
            _context.RolePermissions.Where(r => r.RoleId == roleId)
                .ToList().ForEach(r => _context.RolePermissions.Remove(r));

            AddPermissionToRole(roleId, permission);
        }

        public void UpdateRole(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
        }
    }
}
