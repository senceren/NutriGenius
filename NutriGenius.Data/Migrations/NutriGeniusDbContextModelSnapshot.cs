﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NutriGeniusForm;

#nullable disable

namespace NutriGenius.Data.Migrations
{
    [DbContext(typeof(NutriGeniusDbContext))]
    partial class NutriGeniusDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FoodMeal", b =>
                {
                    b.Property<int>("FoodsId")
                        .HasColumnType("int");

                    b.Property<int>("MealsId")
                        .HasColumnType("int");

                    b.HasKey("FoodsId", "MealsId");

                    b.HasIndex("MealsId");

                    b.ToTable("FoodMeal");
                });

            modelBuilder.Entity("FoodPortion", b =>
                {
                    b.Property<int>("FoodsId")
                        .HasColumnType("int");

                    b.Property<int>("PortionsId")
                        .HasColumnType("int");

                    b.HasKey("FoodsId", "PortionsId");

                    b.HasIndex("PortionsId");

                    b.ToTable("FoodPortion");
                });

            modelBuilder.Entity("MealUser", b =>
                {
                    b.Property<int>("MealsId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("MealsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("MealUser");
                });

            modelBuilder.Entity("NutriGenius.Data.Entities.Abstract_Class.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double?>("Calorie")
                        .HasColumnType("float");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MealDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Meal");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Meal");
                });

            modelBuilder.Entity("NutriGenius.Data.Entities.Classes.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FoodCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("FoodCategoryId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("NutriGenius.Data.Entities.Classes.FoodCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FoodCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Et Yemekleri"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Sebze Yemekleri"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Bakliyat Yemekleri"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Fast Food"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Çorbalar"
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Salatalar"
                        },
                        new
                        {
                            Id = 7,
                            CategoryName = "Meyveler"
                        },
                        new
                        {
                            Id = 8,
                            CategoryName = "Tatlılar"
                        },
                        new
                        {
                            Id = 9,
                            CategoryName = "Atıştırmalıklar"
                        },
                        new
                        {
                            Id = 10,
                            CategoryName = "İçecekler"
                        },
                        new
                        {
                            Id = 11,
                            CategoryName = "Kahvaltılıklar"
                        },
                        new
                        {
                            Id = 12,
                            CategoryName = "Süt Ürünleri"
                        },
                        new
                        {
                            Id = 13,
                            CategoryName = "Tahıl Ürünleri"
                        });
                });

            modelBuilder.Entity("NutriGenius.Data.Entities.Classes.Portion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<double?>("Calorie")
                        .HasColumnType("float");

                    b.Property<int>("Unit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Portions");
                });

            modelBuilder.Entity("NutriGenius.Data.Entities.Classes.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NutriGenius.Data.Entities.SubClasses_Meal.Breakfast", b =>
                {
                    b.HasBaseType("NutriGenius.Data.Entities.Abstract_Class.Meal");

                    b.HasDiscriminator().HasValue("Breakfast");
                });

            modelBuilder.Entity("NutriGenius.Data.Entities.SubClasses_Meal.Dinner", b =>
                {
                    b.HasBaseType("NutriGenius.Data.Entities.Abstract_Class.Meal");

                    b.HasDiscriminator().HasValue("Dinner");
                });

            modelBuilder.Entity("NutriGenius.Data.Entities.SubClasses_Meal.Lunch", b =>
                {
                    b.HasBaseType("NutriGenius.Data.Entities.Abstract_Class.Meal");

                    b.HasDiscriminator().HasValue("Lunch");
                });

            modelBuilder.Entity("NutriGenius.Data.Entities.SubClasses_Meal.Snack", b =>
                {
                    b.HasBaseType("NutriGenius.Data.Entities.Abstract_Class.Meal");

                    b.HasDiscriminator().HasValue("Snack");
                });

            modelBuilder.Entity("FoodMeal", b =>
                {
                    b.HasOne("NutriGenius.Data.Entities.Classes.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NutriGenius.Data.Entities.Abstract_Class.Meal", null)
                        .WithMany()
                        .HasForeignKey("MealsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodPortion", b =>
                {
                    b.HasOne("NutriGenius.Data.Entities.Classes.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NutriGenius.Data.Entities.Classes.Portion", null)
                        .WithMany()
                        .HasForeignKey("PortionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MealUser", b =>
                {
                    b.HasOne("NutriGenius.Data.Entities.Abstract_Class.Meal", null)
                        .WithMany()
                        .HasForeignKey("MealsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NutriGenius.Data.Entities.Classes.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NutriGenius.Data.Entities.Classes.Food", b =>
                {
                    b.HasOne("NutriGenius.Data.Entities.Classes.FoodCategory", "FoodCategory")
                        .WithMany("Foods")
                        .HasForeignKey("FoodCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodCategory");
                });

            modelBuilder.Entity("NutriGenius.Data.Entities.Classes.FoodCategory", b =>
                {
                    b.Navigation("Foods");
                });
#pragma warning restore 612, 618
        }
    }
}
