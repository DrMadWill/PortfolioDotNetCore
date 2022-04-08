using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Extensions
{
    public class PaginationLinkModel
    {

        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public string Link { get; set; }
        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

    }
}
