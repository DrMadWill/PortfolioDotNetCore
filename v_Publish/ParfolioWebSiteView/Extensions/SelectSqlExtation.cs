using FastMember;
using Microsoft.EntityFrameworkCore;
using ParfolioWebSiteView.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Extensions
{
    public static class SelectSqlExtation<TEntity, TContext>
        where TEntity : class
        where TContext : DbContext
    {
        public static async Task<List<TEntity>> SqlData(TContext db,string code)
        {
            var resault =await db.Set<TEntity>().FromSqlRaw(code).ToListAsync();
            return resault;
        }
    }
}
