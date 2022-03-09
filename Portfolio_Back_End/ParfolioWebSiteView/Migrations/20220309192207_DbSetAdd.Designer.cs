﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParfolioWebSiteView.Models;

namespace ParfolioWebSiteView.Migrations
{
    [DbContext(typeof(PorfolioDbContext))]
    [Migration("20220309192207_DbSetAdd")]
    partial class DbSetAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ParfolioWebSiteView.Models.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descriptoion")
                        .HasColumnType("ntext");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(75)")
                        .HasMaxLength(75);

                    b.HasKey("Id");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.Achievements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasMaxLength(1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AwardWon")
                        .HasColumnType("int");

                    b.Property<int>("TotalClents")
                        .HasColumnType("int");

                    b.Property<int>("WorksComplate")
                        .HasColumnType("int");

                    b.Property<int>("YearsExperoence")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlogCategoryId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.BlogCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("BlogCategories");
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(75)")
                        .HasMaxLength(75);

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.ContactOnline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("ContactOnlines");
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.Home", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HomeSlogan")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<bool>("IsShow")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Homes");
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.Portfolio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("PortfolioCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioCategoryId");

                    b.ToTable("Portfolios");
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.PortfolioCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PortfolioCategories");
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.PortfolioDetail", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Client")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Descriptoion")
                        .HasColumnType("ntext");

                    b.Property<string>("LocatoionURL")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("PortfolioDetails");
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.Referance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Referances");
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descriptoion")
                        .HasColumnType("ntext");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AboutId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.SkillCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AboutId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(75)")
                        .HasMaxLength(75);

                    b.Property<int>("Percent")
                        .HasColumnType("int")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.ToTable("SkillCodes");
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.Blog", b =>
                {
                    b.HasOne("ParfolioWebSiteView.Models.BlogCategory", "BlogCategory")
                        .WithMany("Blogs")
                        .HasForeignKey("BlogCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.ContactOnline", b =>
                {
                    b.HasOne("ParfolioWebSiteView.Models.Contact", "Contact")
                        .WithMany("ContactOnlines")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.Portfolio", b =>
                {
                    b.HasOne("ParfolioWebSiteView.Models.PortfolioCategory", "PortfolioCategory")
                        .WithMany("Portfolios")
                        .HasForeignKey("PortfolioCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.PortfolioDetail", b =>
                {
                    b.HasOne("ParfolioWebSiteView.Models.Portfolio", "Portfolio")
                        .WithOne("PortfolioDetail")
                        .HasForeignKey("ParfolioWebSiteView.Models.PortfolioDetail", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.Skill", b =>
                {
                    b.HasOne("ParfolioWebSiteView.Models.About", "About")
                        .WithMany("Skills")
                        .HasForeignKey("AboutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ParfolioWebSiteView.Models.SkillCode", b =>
                {
                    b.HasOne("ParfolioWebSiteView.Models.About", "About")
                        .WithMany("SkillCodes")
                        .HasForeignKey("AboutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
