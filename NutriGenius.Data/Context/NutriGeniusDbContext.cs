using Microsoft.EntityFrameworkCore;
using NutriGenius.Data.Entities.Abstract_Class;
using NutriGenius.Data.Entities.Classes;
using NutriGenius.Data.Entities.SubClasses_Meal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriGeniusForm
{
    public class NutriGeniusDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Food> Foods => Set<Food>();
        public DbSet<Breakfast> Breakfasts => Set<Breakfast>();
        public DbSet<Lunch> Lunches => Set<Lunch>();
        public DbSet<Dinner> Dinners => Set<Dinner>();
        public DbSet<Snack> Snacks => Set<Snack>();
        public DbSet<Portion> Portions => Set<Portion>();
        public DbSet<FoodCategory> FoodCategories => Set<FoodCategory>();

        public DbSet<UserFoodPortionMeal> UserFoodPortionMeals => Set<UserFoodPortionMeal>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localDB)\MSSQLLocalDB;database=NutriGeniusDb; trusted_connection=true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserFoodPortionMeal>()
                .HasKey(k => new {k.UserId, k.MealId, k.FoodId, k.PortionId});

            modelBuilder.Entity<UserFoodPortionMeal>()
                 .HasOne(x => x.User)
                 .WithMany(x => x.UserFoodPortionMeals)
                 .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<UserFoodPortionMeal>()
                .HasOne(x => x.Meal)
                .WithMany(x => x.UserFoodPortionMeals)
                .HasForeignKey(x => x.MealId);

            modelBuilder.Entity<UserFoodPortionMeal>()
                .HasOne(x => x.Food)
                .WithMany(x => x.UserFoodPortionMeals)
                .HasForeignKey(x => x.FoodId);

            modelBuilder.Entity<UserFoodPortionMeal>()
                .HasOne(x => x.Portion)
                .WithMany(x => x.UserFoodPortionMeals)
                .HasForeignKey(x => x.PortionId);

            modelBuilder.Entity<FoodCategory>().HasData(
                new FoodCategory { Id = 1, CategoryName = "Et Yemekleri" },
                new FoodCategory { Id = 2, CategoryName = "Sebze Yemekleri" },
                new FoodCategory { Id = 3, CategoryName = "Bakliyat Yemekleri" },
                new FoodCategory { Id = 4, CategoryName = "Fast Food" },
                new FoodCategory { Id = 5, CategoryName = "Çorbalar" },
                new FoodCategory { Id = 6, CategoryName = "Salatalar" },
                new FoodCategory { Id = 7, CategoryName = "Meyveler" },
                new FoodCategory { Id = 8, CategoryName = "Tatlılar" },
                new FoodCategory { Id = 9, CategoryName = "Atıştırmalıklar" },
                new FoodCategory { Id = 10, CategoryName = "İçecekler" },
                new FoodCategory { Id = 11, CategoryName = "Kahvaltılıklar" },
                new FoodCategory { Id = 12, CategoryName = "Süt Ürünleri" },
                new FoodCategory { Id = 13, CategoryName = "Tahıl Ürünleri" }
                );

        }
    }
}
