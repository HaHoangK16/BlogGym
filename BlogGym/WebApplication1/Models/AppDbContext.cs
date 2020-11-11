using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Gym> gyms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Gạo" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Thịt" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Hoa Quả" });

            modelBuilder.Entity<Gym>().HasData(new Gym
            {
                Id = 1,
                Name = "Gạo Lứt Huế",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ImageUrl = "https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png",
                CategoryId = 1
            });
            modelBuilder.Entity<Gym>().HasData(new Gym
            {
                Id = 2,
                Name = "Thịt ba chỉ Huế",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ImageUrl = "https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png",
                CategoryId = 2
            });
            modelBuilder.Entity<Gym>().HasData(new Gym
            {
                Id = 3,
                Name = "Gạo Lào",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ImageUrl = "https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png",
                CategoryId = 1
            });
            modelBuilder.Entity<Gym>().HasData(new Gym
            {
                Id = 4,
                Name = "Mít trộn Huế",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ImageUrl = "https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png",
                CategoryId = 3
            });
            modelBuilder.Entity<Gym>().HasData(new Gym
            {
                Id = 5,
                Name = "Gạo Thơm xứ Quảng",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                ImageUrl = "https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png",
                CategoryId = 1
            });
        }
    }
}
