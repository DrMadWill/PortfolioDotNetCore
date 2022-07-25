using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Extensions
{
    public class PaginationList<T> :List<T>
    {
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }

        // Link Model Create 

        private PaginationLinkModel _PaginationLinkModel;
        public PaginationLinkModel PaginationLinkModel { get { return _PaginationLinkModel; } }

        public PaginationList(List<T> items, int count, int pageIndex, int pageSize,string link)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(items);
            _PaginationLinkModel = new PaginationLinkModel
            {
                PageIndex = pageIndex,
                TotalPages = this.TotalPages,
                Link = link
            };
        }

        public static async Task<PaginationList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize,string link)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new PaginationList<T>(items, count, pageIndex, pageSize, link);
        }
    }
}
