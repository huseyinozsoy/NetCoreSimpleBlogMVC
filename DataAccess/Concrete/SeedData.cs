using System.Collections.Generic;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Body = "Net Core Ef Core ile CRUD işlemleri",
                    Description = "Net Core Ef Core ile CRUD işlemleri...",
                    Title = "Net Core Ef Core - 1",
                    IsApproved = true
                    //Category = new List<Category>() { new Category { Id = 1, CategoryNName = "Net Core" }, new Category { Id = 2, CategoryNName = "Ef Core" } }
                },
                new Blog
                {
                    Id = 2,
                    Body = "Merhaba Angulara giriş yapalım",
                    Description = "Angulara giriş yazısı...",
                    Title = "Angular - 0",
                    IsApproved = true
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryNName = "Net Core" },
                new Category { Id = 2, CategoryNName = "EF Core" },
                new Category { Id = 3, CategoryNName = "Angular" }
            );
            modelBuilder.Entity<BlogCategory>().HasData(
                new BlogCategory { BlogId = 1, CategoryId=1 },
                new BlogCategory { BlogId = 2, CategoryId=3 }
            );
        }
    }
}