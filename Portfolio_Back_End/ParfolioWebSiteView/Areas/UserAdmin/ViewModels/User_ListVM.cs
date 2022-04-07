using Microsoft.AspNetCore.Identity;
using PagedList;
using ParfolioWebSiteView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Areas.UserAdmin.ViewModels
{
    public class User_ListVM
    {
        public IPagedList<User> Users { get; set; }
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
        public int CurrentPage { get; set; }

        public int Previous
        {
            get
            {
                if (CurrentPage == 1)
                {
                    return 1;
                }

                return CurrentPage - 1;
            }
        }

        public int Nextviews
        {
            get
            {
                if (TotalPaged == CurrentPage)
                {
                    return TotalPaged;
                }

                return CurrentPage + 1;

            }
        }
        private int _TolalPage;

        public int TotalPaged { get { return _TolalPage; } }

        public void PagedCount(int totalCountElement, int countElemet)
        {
            if (totalCountElement == 0)
                _TolalPage = 1;
            else if (totalCountElement % countElemet == 0)
                _TolalPage = totalCountElement / countElemet;
            else
                _TolalPage = totalCountElement / countElemet + 1;
        }
    }
}
