using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace DotNetAutentication.Models
{
    public class CustomRole : RoleProvider
    {
        public override bool IsUserInRole(string username, string roleName)
        {
            //throw new NotImplementedException();
            var userRoles = GetRolesForUser(username);
            return userRoles.Contains(roleName);
        }
        public override string[] GetRolesForUser(string username)
        {
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                return null;
            }
            var userRoles = new string[] { };

            using (AutenticationEntities dbContex = new AutenticationEntities())
            {
                var selectUser = (from us in dbContex.User.Include("Role")
                                  where string.Compare(us.UserName, username) == 0
                                  select us).FirstOrDefault();
                if (selectUser != null)
                {

                    userRoles = new[] { selectUser.Roles.RoleName.ToString() };
                }
                return userRoles.ToArray();
            }
        }

        #region Overide of Role Provaider

        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }
        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }
        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }
        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }
        public override string[] GetAllRoles()
        {
            throw new NotFiniteNumberException();
        }
        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotFiniteNumberException();
        }
        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}