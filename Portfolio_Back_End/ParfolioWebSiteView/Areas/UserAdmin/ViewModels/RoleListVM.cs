using Microsoft.AspNetCore.Identity;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Areas.UserAdmin.ViewModels
{
    public class RoleListVM
    {
        public IPagedList<IdentityRole> Roles { get; set; }
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

            if (totalCountElement % countElemet == 0)
                _TolalPage = totalCountElement / countElemet;
            else
                _TolalPage = totalCountElement / countElemet + 1;

        }
    }
}
