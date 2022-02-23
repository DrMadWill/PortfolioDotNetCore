using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class PorfolioDbContext : DbContext
    {
        public PorfolioDbContext(DbContextOptions<PorfolioDbContext> dbContext) : base(dbContext) { }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Achievements> Achievements { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactOnline> ContactOnlines { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioCategory> PortfolioCategories { get; set; }
        public DbSet<PortfolioDetail> PortfolioDetails { get; set; }
        public DbSet<Referance> Referances { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillCode> SkillCodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Portfolio>()
                .Property(b => b.Date)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Blog>()
                .Property(b => b.Date)
                .HasDefaultValueSql("getdate()");
        }


    }
}
