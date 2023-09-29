using BulkyBook.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAccess.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
        { 

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category {Id =1 ,Name = "Action", DisplayOrder = 1 },
                new Category {Id =2 ,Name = "SciFi", DisplayOrder = 2 },
                new Category {Id =3 ,Name = "History", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { 
                Id = 1,
                Title = "Title1",
                Description = "Description1",
                Author = "Author1",
                ISBN = "SBN001",
                ListPrice = 99,
                Price = 90,
                Price50 = 85,
                Price100 = 80
                },
                new Product {
                    Id = 2,
                    Title = "Title2",
                    Description = "Description2",
                    Author = "Author2",
                    ISBN = "SBN002",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80
                }
                );
        }
    }
}
