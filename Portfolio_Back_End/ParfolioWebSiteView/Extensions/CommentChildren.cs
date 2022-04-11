using Microsoft.EntityFrameworkCore;
using ParfolioWebSiteView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Extensions
{
    public static class CommentChildren
    {
        public static async Task<List<Commet>> ComentChildernAsync(this IQueryable<Commet> soruce, int id)
        {
            // Select Children Comment
            var coments = await soruce.Where(dr => dr.ParentId == id).ToListAsync();

            var commentChild = coments.FindAll(dr => dr.IsChild);  

            foreach (var item in commentChild)
                coments.InsertRange(coments.IndexOf(item),
                                    (await soruce.ComentChildernAsync(item.Id))
                                    );
            return coments;
        }
    }
}
