using Microsoft.EntityFrameworkCore;

namespace GlowingApp.Models
{
    public class GlowingDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Catagories { get; set; }
        public DbSet<Section1> Section1s { get; set; }
        public DbSet<BlogCatagory> BlogCatagories { get; set; }





        //public GlowingDbContext()
        //{

        //}
        public 
            GlowingDbContext(DbContextOptions opt) : base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    CatagoryName = "EyeLiner",
                    Icon = ""

                },
                new Category
                { 
                Id=2,
                CatagoryName="HairCream",
                Icon=""
                }
    
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name= "Natural Coconut Cleansing Oil",
                    Description= "Niacinamide and Vitamin C are two anti-aging superstars but not usually formulated together because of their different pH levels.",
                    PhotoUrl= "http://templates.g5plus.net/glowing/images/product-07.jpg",
                    CatagoryId=1,
                    Isfeatured=true,
                    IsNew=true,
                    Price=200,


                },
                 new Product
                 {
                     Id = 2,
                     Name = "Natural2",
                     Description = "Niacinamide 2 and Vitamin C are two anti-aging superstars but not usually formulated together because of their different pH levels.",
                     PhotoUrl = "http://templates.g5plus.net/glowing/images/product-15.jpg",
                     CatagoryId = 2,
                     Isfeatured = false,
                     Price=400,
                     Discount=190.99M
                 }

                );
        }



    }
}
