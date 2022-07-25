using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class PorfolioDbContext : IdentityDbContext<User>
    {
        public PorfolioDbContext(DbContextOptions<PorfolioDbContext> dbContext) : base(dbContext) { }
        public DbSet<User> User { get; set; }
        public DbSet<DetailImage> DetailImages { get; set; }
        public DbSet<Home> Homes { get; set; }
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
        public DbSet<SkillCode> SkillCodes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BlogToTag> BlogToTags { get; set; }
        public DbSet<BlogDetails> BlogDetails { get; set; }
        public DbSet<Commet> Commets { get; set; }
        public DbSet<MessengeUser> MessengeUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            // Default Date
            modelBuilder.Entity<Portfolio>()
                .Property(b => b.Date)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Blog>()
                .Property(b => b.Date)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<MessengeUser>()
               .Property(b => b.Date)
               .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Commet>()
               .Property(b => b.Date)
               .HasDefaultValueSql("getdate()");

            //Unique Key
            modelBuilder.Entity<BlogCategory>()
                .HasIndex(u => u.Name)
                .IsUnique();

            modelBuilder.Entity<PortfolioCategory>()
                .HasIndex(u => u.Name)
                .IsUnique();

            modelBuilder.Entity<Tag>()
                .HasIndex(u => u.Name)
                .IsUnique();

            // Many To Many
            modelBuilder.Entity<BlogToTag>()
                .HasKey(x => new { x.TagId,x.BlogId});

            modelBuilder.Entity<BlogToTag>()
                .HasOne(x => x.Tag)
                .WithMany(y => y.BlogToTags)
                .HasForeignKey(fk => fk.TagId);

            modelBuilder.Entity<BlogToTag>()
                .HasOne(x => x.Blog)
                .WithMany(y => y.BlogToTags)
                .HasForeignKey(fk => fk.BlogId);

        }
    }
}
