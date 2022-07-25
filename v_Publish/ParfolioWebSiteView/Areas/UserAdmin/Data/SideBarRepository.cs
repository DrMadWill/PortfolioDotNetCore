using ParfolioWebSiteView.Areas.UserAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Areas.UserAdmin.Data
{
    public class SideBarRepository
    {

        private List<Bar> _bars { get; set; }

        public SideBarRepository()
        {
            _bars = new List<Bar>
            {
                new Bar
                {
                    Id=1,
                    Name="Messenge Box",
                    Icon ="bi bi-inbox-fill",
                    BarChildren = new List<BarChild>
                    {
                        new BarChild{Id = 1 ,Name="List",Link="/UserAdmin/Messange/List",BarId =1}
                    }
                },
                new Bar
                {
                    Id=2,
                    Name="User",
                    Icon ="ti-user",
                    BarChildren = new List<BarChild>
                    {
                        new BarChild{Id = 2 ,Name="Account",Link="/UserAdmin/UserAccount/Account",BarId =2},
                        new BarChild{Id = 3 ,Name="Settings",Link="/UserAdmin/Settings/Index",BarId =2}
                    }
                },
                new Bar
                {
                    Id=3,
                    Name="Services",
                    Icon ="bi bi-wrench-adjustable-circle",
                    BarChildren = new List<BarChild>
                    {
                        new BarChild{Id = 4 ,Name="List",Link="/UserAdmin/Services/List",BarId =3},
                        new BarChild{Id = 5 ,Name="Create",Link="/UserAdmin/Services/Create",BarId =3}
                    }
                },
                new Bar
                {
                    Id=4,
                    Name="Achievements",
                    Icon ="bi bi-award",
                    BarChildren = new List<BarChild>
                    {
                        new BarChild{Id = 6 ,Name="List",Link="/UserAdmin/Achievements/List",BarId =4},
                        new BarChild{Id = 7 ,Name="Create",Link="/UserAdmin/Achievements/Create",BarId =4}
                    }
                },
                new Bar
                {
                    Id=5,
                    Name="Portfolio",
                    Icon ="ti-briefcase",
                    BarChildren = new List<BarChild>
                    {
                        new BarChild{Id = 8 ,Name="List",Link="/UserAdmin/Portfolio/List",BarId =5},
                        new BarChild{Id = 9 ,Name="Create",Link="/UserAdmin/Portfolio/Create",BarId =5}
                    }
                },
                new Bar
                {
                    Id=6,
                    Name="Referans",
                    Icon ="bi bi-people",
                    BarChildren = new List<BarChild>
                    {
                        new BarChild{Id = 10 ,Name="List",Link="/UserAdmin/Referance/List",BarId =6},
                        new BarChild{Id = 11 ,Name="Create",Link="/UserAdmin/Referance/Create",BarId =6}
                    }
                },
                new Bar
                {
                    Id=7,
                    Name="Blog",
                    Icon ="bi bi-chat-left-text",
                    BarChildren = new List<BarChild>
                    {
                        new BarChild{Id = 12 ,Name="List",Link="/UserAdmin/Blog/List",BarId =7},
                        new BarChild{Id = 13 ,Name="Create",Link="/UserAdmin/Blog/Create",BarId =7}
                    }
                }
            };
        }

        public List<Bar> Bars
        {
            get { return _bars; }
        }

        public BarChild GetChildIdByLink(string link)
        {
            foreach (var item in _bars)
            {
                var child = item.BarChildren.Find(dr => dr.Link == link);
                if (child != null) return child;
            }
            return null;
        }

        public void Adds(params Bar[] bar)
        {
            _bars.AddRange(bar);
        }



    }
}
