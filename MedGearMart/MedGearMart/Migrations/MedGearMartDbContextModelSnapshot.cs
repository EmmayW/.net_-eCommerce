﻿// <auto-generated />
using System;
using MedGearMart.Models.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedGearMart.Migrations
{
    [DbContext(typeof(MedGearMartDbContext))]
    partial class MedGearMartDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MedGearMart.Models.DomainModel.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("MedGearMart.Models.DomainModel.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryDescription = "Equipment used for medical purposes.",
                            CategoryName = "Medical Devices"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryDescription = "Tools and devices for medical diagnostics.",
                            CategoryName = "Diagnostics"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryDescription = "Instruments used in surgical procedures.",
                            CategoryName = "Surgical Instruments"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryDescription = "Products related to patient care and comfort.",
                            CategoryName = "Patient Care"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryDescription = "Protective gear for medical professionals.",
                            CategoryName = "Personal Protective Equipment"
                        });
                });

            modelBuilder.Entity("MedGearMart.Models.DomainModel.Gear", b =>
                {
                    b.Property<int>("GearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GearId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GearName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("GearId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Gears");

                    b.HasData(
                        new
                        {
                            GearId = 1,
                            CategoryId = 1,
                            Description = "Portable heart monitoring device.",
                            GearName = "Heart Monitor",
                            ImageUrl = "heart_monitor.jpg",
                            Price = 250.00m,
                            Stock = 10
                        },
                        new
                        {
                            GearId = 2,
                            CategoryId = 1,
                            Description = "Digital blood pressure cuff.",
                            GearName = "Blood Pressure Cuff",
                            ImageUrl = "blood_pressure_cuff.jpg",
                            Price = 50.00m,
                            Stock = 20
                        },
                        new
                        {
                            GearId = 3,
                            CategoryId = 1,
                            Description = "Infrared forehead thermometer.",
                            GearName = "Thermometer",
                            ImageUrl = "thermometer.jpg",
                            Price = 20.00m,
                            Stock = 50
                        },
                        new
                        {
                            GearId = 4,
                            CategoryId = 2,
                            Description = "Digital X-ray imaging system.",
                            GearName = "X-ray Machine",
                            ImageUrl = "xray_machine.jpg",
                            Price = 5000.00m,
                            Stock = 0
                        },
                        new
                        {
                            GearId = 5,
                            CategoryId = 2,
                            Description = "Portable ultrasound scanner.",
                            GearName = "Ultrasound Device",
                            ImageUrl = "ultrasound_device.jpg",
                            Price = 3000.00m,
                            Stock = 8
                        },
                        new
                        {
                            GearId = 6,
                            CategoryId = 2,
                            Description = "Comprehensive blood test kit.",
                            GearName = "Blood Test Kit",
                            ImageUrl = "blood_test_kit.jpg",
                            Price = 100.00m,
                            Stock = 100
                        },
                        new
                        {
                            GearId = 7,
                            CategoryId = 3,
                            Description = "High-precision surgical scalpel.",
                            GearName = "Scalpel",
                            ImageUrl = "scalpel.jpg",
                            Price = 15.00m,
                            Stock = 200
                        },
                        new
                        {
                            GearId = 8,
                            CategoryId = 3,
                            Description = "Stainless steel surgical forceps.",
                            GearName = "Forceps",
                            ImageUrl = "forceps.jpg",
                            Price = 25.00m,
                            Stock = 150
                        },
                        new
                        {
                            GearId = 9,
                            CategoryId = 3,
                            Description = "Sharp surgical scissors.",
                            GearName = "Surgical Scissors",
                            ImageUrl = "surgical_scissors.jpg",
                            Price = 30.00m,
                            Stock = 100
                        },
                        new
                        {
                            GearId = 10,
                            CategoryId = 4,
                            Description = "Comfortable and durable wheelchair.",
                            GearName = "Wheelchair",
                            ImageUrl = "wheelchair.jpg",
                            Price = 200.00m,
                            Stock = 15
                        },
                        new
                        {
                            GearId = 11,
                            CategoryId = 4,
                            Description = "Adjustable hospital bed with mattress.",
                            GearName = "Hospital Bed",
                            ImageUrl = "hospital_bed.jpg",
                            Price = 1500.00m,
                            Stock = 10
                        },
                        new
                        {
                            GearId = 12,
                            CategoryId = 4,
                            Description = "Portable oxygen tank with mask.",
                            GearName = "Oxygen Tank",
                            ImageUrl = "oxygen_tank.jpg",
                            Price = 300.00m,
                            Stock = 30
                        },
                        new
                        {
                            GearId = 13,
                            CategoryId = 5,
                            Description = "N95 respiratory face mask.",
                            GearName = "Face Mask",
                            ImageUrl = "face_mask.jpg",
                            Price = 5.00m,
                            Stock = 500
                        },
                        new
                        {
                            GearId = 14,
                            CategoryId = 5,
                            Description = "Disposable nitrile gloves.",
                            GearName = "Gloves",
                            ImageUrl = "gloves.jpg",
                            Price = 10.00m,
                            Stock = 1000
                        },
                        new
                        {
                            GearId = 15,
                            CategoryId = 5,
                            Description = "Anti-fog protective goggles.",
                            GearName = "Protective Goggles",
                            ImageUrl = "protective_goggles.jpg",
                            Price = 20.00m,
                            Stock = 300
                        });
                });

            modelBuilder.Entity("MedGearMart.Models.DomainModel.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MedGearMart.Models.DomainModel.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"), 1L, 1);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId1")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("OrderId1");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MedGearMart.Models.DomainModel.Gear", b =>
                {
                    b.HasOne("MedGearMart.Models.DomainModel.Category", "Category")
                        .WithMany("Gears")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MedGearMart.Models.DomainModel.Order", b =>
                {
                    b.HasOne("MedGearMart.Models.DomainModel.AppUser", "User")
                        .WithMany("Activities")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MedGearMart.Models.DomainModel.OrderItem", b =>
                {
                    b.HasOne("MedGearMart.Models.DomainModel.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MedGearMart.Models.DomainModel.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId1");

                    b.HasOne("MedGearMart.Models.DomainModel.Gear", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MedGearMart.Models.DomainModel.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MedGearMart.Models.DomainModel.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedGearMart.Models.DomainModel.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MedGearMart.Models.DomainModel.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MedGearMart.Models.DomainModel.AppUser", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("MedGearMart.Models.DomainModel.Category", b =>
                {
                    b.Navigation("Gears");
                });

            modelBuilder.Entity("MedGearMart.Models.DomainModel.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
