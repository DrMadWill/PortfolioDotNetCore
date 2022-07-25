using Microsoft.AspNetCore.Identity;
using PagedList;
using ParfolioWebSiteView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParfolioWebSiteView.Extensions;

namespace ParfolioWebSiteView.Areas.UserAdmin.ViewModels
{
    public class User_ListVM
    {
        public PaginationList<User> Users { get; set; }
        public List<IdentityRole> Roles { get; set; }
        public List<IdentityUserRole<string>> UserRoles { get; set; }
        public List<string> FindAllRoleNameById(string id)
        {
            List<string> names = new List<string>();
            var RoleIds = UserRoles
                .FindAll(dr => dr.UserId == id)
                .Select(x => x.RoleId);
            foreach (var item in RoleIds)
            {
                var roleName = Roles.Find(dr => dr.Id == item).Name;
                names.Add(roleName);
            }
            return names;
        }
    }
}
