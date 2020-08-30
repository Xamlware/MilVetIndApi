﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MilVetIndApi.Authentication;

namespace MilVetIndApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MilVetIndApi.Authentication.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("MilVetIndApi.Authentication.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("MilVetIndApi.Authentication.ApplicationUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("MilVetIndApi.Data.District", b =>
                {
                    b.Property<int>("PK_District")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FK_Region")
                        .HasColumnType("int");

                    b.HasKey("PK_District");

                    b.ToTable("District");

                    b.HasData(
                        new
                        {
                            PK_District = 1,
                            DistrictName = "District 1",
                            FK_Region = 1
                        });
                });

            modelBuilder.Entity("MilVetIndApi.Data.Employee", b =>
                {
                    b.Property<int>("PK_Employee")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AspUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FK_Country")
                        .HasColumnType("int");

                    b.Property<int>("FK_Gender")
                        .HasColumnType("int");

                    b.Property<int>("FK_Race")
                        .HasColumnType("int");

                    b.Property<int>("FK_State")
                        .HasColumnType("int");

                    b.Property<int>("FK_Store")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSuffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_Employee");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            PK_Employee = 1,
                            Address = "5000B Newport Road",
                            Address1 = "",
                            AspUserId = "",
                            City = "Kinzers",
                            Email = "jbaird@outlook.com",
                            EmployeeId = "FS1",
                            EmployeeName = "Employee 1",
                            FK_Country = 1,
                            FK_Gender = 1,
                            FK_Race = 1,
                            FK_State = 38,
                            FK_Store = 1,
                            FirstName = "Charles",
                            LastName = "Baird",
                            MiddleName = "John",
                            NameSuffix = "",
                            ZipCode = "17535"
                        });
                });

            modelBuilder.Entity("MilVetIndApi.Data.EmployeeTime", b =>
                {
                    b.Property<int>("PK_EmployeeTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FK_Store")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("PK_EmployeeTime");

                    b.ToTable("EmployeeTime");
                });

            modelBuilder.Entity("MilVetIndApi.Data.Gender", b =>
                {
                    b.Property<int>("PK_Gender")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_Gender");

                    b.ToTable("Gender");

                    b.HasData(
                        new
                        {
                            PK_Gender = 1,
                            GenderName = "Male"
                        },
                        new
                        {
                            PK_Gender = 2,
                            GenderName = "Female"
                        },
                        new
                        {
                            PK_Gender = 3,
                            GenderName = "Other"
                        });
                });

            modelBuilder.Entity("MilVetIndApi.Data.Race", b =>
                {
                    b.Property<int>("PK_Race")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RaceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_Race");

                    b.ToTable("Race");

                    b.HasData(
                        new
                        {
                            PK_Race = 1,
                            RaceName = "White"
                        },
                        new
                        {
                            PK_Race = 2,
                            RaceName = "Black"
                        },
                        new
                        {
                            PK_Race = 3,
                            RaceName = "American Indian"
                        },
                        new
                        {
                            PK_Race = 4,
                            RaceName = "Native Alaskan"
                        },
                        new
                        {
                            PK_Race = 5,
                            RaceName = "Asian"
                        },
                        new
                        {
                            PK_Race = 6,
                            RaceName = "Native Hawaiian"
                        },
                        new
                        {
                            PK_Race = 7,
                            RaceName = "Pacific Islander"
                        },
                        new
                        {
                            PK_Race = 8,
                            RaceName = "Other"
                        });
                });

            modelBuilder.Entity("MilVetIndApi.Data.Region", b =>
                {
                    b.Property<int>("PK_Region")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_Region");

                    b.ToTable("Region");

                    b.HasData(
                        new
                        {
                            PK_Region = 1,
                            RegionName = "Region 1"
                        });
                });

            modelBuilder.Entity("MilVetIndApi.Data.Sale", b =>
                {
                    b.Property<int>("PK_Sale")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FK_Store")
                        .HasColumnType("int");

                    b.Property<int>("Payment")
                        .HasColumnType("int");

                    b.Property<DateTime>("SalesDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("Tax")
                        .HasColumnType("real");

                    b.Property<float>("TotalSales")
                        .HasColumnType("real");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_Sale");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("MilVetIndApi.Data.SaleItem", b =>
                {
                    b.Property<int>("PK_SalesItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<int>("FK_Inventory")
                        .HasColumnType("int");

                    b.Property<int>("FK_Sales")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.HasKey("PK_SalesItem");

                    b.ToTable("SaleItem");
                });

            modelBuilder.Entity("MilVetIndApi.Data.State", b =>
                {
                    b.Property<int>("PK_State")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_State");

                    b.ToTable("State");

                    b.HasData(
                        new
                        {
                            PK_State = 1,
                            Abbreviation = "AL",
                            StateName = "Alabama"
                        },
                        new
                        {
                            PK_State = 2,
                            Abbreviation = "AK",
                            StateName = "Alaska"
                        },
                        new
                        {
                            PK_State = 3,
                            Abbreviation = "AZ",
                            StateName = "Arizona"
                        },
                        new
                        {
                            PK_State = 4,
                            Abbreviation = "AR",
                            StateName = "Arkansas"
                        },
                        new
                        {
                            PK_State = 5,
                            Abbreviation = "AL",
                            StateName = "California"
                        },
                        new
                        {
                            PK_State = 6,
                            Abbreviation = "CO",
                            StateName = "Colorado"
                        },
                        new
                        {
                            PK_State = 7,
                            Abbreviation = "CT",
                            StateName = "Connecticut"
                        },
                        new
                        {
                            PK_State = 8,
                            Abbreviation = "DE",
                            StateName = "Delaware"
                        },
                        new
                        {
                            PK_State = 9,
                            Abbreviation = "FL",
                            StateName = "Florida"
                        },
                        new
                        {
                            PK_State = 10,
                            Abbreviation = "GA",
                            StateName = "Georgia"
                        },
                        new
                        {
                            PK_State = 11,
                            Abbreviation = "HI",
                            StateName = "Hawaii"
                        },
                        new
                        {
                            PK_State = 12,
                            Abbreviation = "ID",
                            StateName = "Idaho"
                        },
                        new
                        {
                            PK_State = 13,
                            Abbreviation = "IL",
                            StateName = "Illinois"
                        },
                        new
                        {
                            PK_State = 14,
                            Abbreviation = "IN",
                            StateName = "Indiana"
                        },
                        new
                        {
                            PK_State = 15,
                            Abbreviation = "IA",
                            StateName = "Iowa"
                        },
                        new
                        {
                            PK_State = 16,
                            Abbreviation = "KS",
                            StateName = "Kansas"
                        },
                        new
                        {
                            PK_State = 17,
                            Abbreviation = "KY",
                            StateName = "Kentucky"
                        },
                        new
                        {
                            PK_State = 18,
                            Abbreviation = "LA",
                            StateName = "Louisiana"
                        },
                        new
                        {
                            PK_State = 19,
                            Abbreviation = "ME",
                            StateName = "Maine"
                        },
                        new
                        {
                            PK_State = 20,
                            Abbreviation = "MD",
                            StateName = "Maryland"
                        },
                        new
                        {
                            PK_State = 21,
                            Abbreviation = "MA",
                            StateName = "Massachusetts"
                        },
                        new
                        {
                            PK_State = 22,
                            Abbreviation = "MI",
                            StateName = "Michigan"
                        },
                        new
                        {
                            PK_State = 23,
                            Abbreviation = "MN",
                            StateName = "Minnesota"
                        },
                        new
                        {
                            PK_State = 24,
                            Abbreviation = "MI",
                            StateName = "Mississippi"
                        },
                        new
                        {
                            PK_State = 25,
                            Abbreviation = "MO",
                            StateName = "Missouri"
                        },
                        new
                        {
                            PK_State = 26,
                            Abbreviation = "MT",
                            StateName = "Montana"
                        },
                        new
                        {
                            PK_State = 27,
                            Abbreviation = "NE",
                            StateName = "Nebraska"
                        },
                        new
                        {
                            PK_State = 28,
                            Abbreviation = "NV",
                            StateName = "Nevada"
                        },
                        new
                        {
                            PK_State = 29,
                            Abbreviation = "NH",
                            StateName = "New Hampshire"
                        },
                        new
                        {
                            PK_State = 30,
                            Abbreviation = "NJ",
                            StateName = "New Jersey"
                        },
                        new
                        {
                            PK_State = 31,
                            Abbreviation = "NM",
                            StateName = "New Mexico"
                        },
                        new
                        {
                            PK_State = 32,
                            Abbreviation = "NY",
                            StateName = "New York"
                        },
                        new
                        {
                            PK_State = 33,
                            Abbreviation = "NC",
                            StateName = "North Carolina"
                        },
                        new
                        {
                            PK_State = 34,
                            Abbreviation = "ND",
                            StateName = "North Dakota"
                        },
                        new
                        {
                            PK_State = 35,
                            Abbreviation = "OH",
                            StateName = "Ohio"
                        },
                        new
                        {
                            PK_State = 36,
                            Abbreviation = "OK",
                            StateName = "Oklahoma"
                        },
                        new
                        {
                            PK_State = 37,
                            Abbreviation = "OR",
                            StateName = "Oregon"
                        },
                        new
                        {
                            PK_State = 38,
                            Abbreviation = "PA",
                            StateName = "Penssylvania"
                        },
                        new
                        {
                            PK_State = 39,
                            Abbreviation = "RI",
                            StateName = "Rhode Island"
                        },
                        new
                        {
                            PK_State = 40,
                            Abbreviation = "SC",
                            StateName = "South Carolina"
                        },
                        new
                        {
                            PK_State = 41,
                            Abbreviation = "SD",
                            StateName = "South Dakota"
                        },
                        new
                        {
                            PK_State = 42,
                            Abbreviation = "TN",
                            StateName = "Tennesee"
                        },
                        new
                        {
                            PK_State = 43,
                            Abbreviation = "TX",
                            StateName = "Texas"
                        },
                        new
                        {
                            PK_State = 44,
                            Abbreviation = "UT",
                            StateName = "Utah"
                        },
                        new
                        {
                            PK_State = 45,
                            Abbreviation = "VT",
                            StateName = "Vermont"
                        },
                        new
                        {
                            PK_State = 46,
                            Abbreviation = "VA",
                            StateName = "Virginia"
                        },
                        new
                        {
                            PK_State = 47,
                            Abbreviation = "WA",
                            StateName = "Washington"
                        },
                        new
                        {
                            PK_State = 48,
                            Abbreviation = "WV",
                            StateName = "West Virginia"
                        },
                        new
                        {
                            PK_State = 49,
                            Abbreviation = "WI",
                            StateName = "Wisconsin"
                        },
                        new
                        {
                            PK_State = 50,
                            Abbreviation = "WY",
                            StateName = "Wyoming"
                        });
                });

            modelBuilder.Entity("MilVetIndApi.Data.Store", b =>
                {
                    b.Property<int>("PK_Store")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FK_District")
                        .HasColumnType("int");

                    b.Property<int>("LastId")
                        .HasColumnType("int");

                    b.Property<string>("StoreAbbreviation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_Store");

                    b.ToTable("Store");

                    b.HasData(
                        new
                        {
                            PK_Store = 1,
                            FK_District = 1,
                            LastId = 0,
                            StoreAbbreviation = "FS",
                            StoreName = "First Store"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("MilVetIndApi.Authentication.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MilVetIndApi.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MilVetIndApi.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MilVetIndApi.Authentication.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MilVetIndApi.Authentication.ApplicationUserRole", b =>
                {
                    b.HasOne("MilVetIndApi.Authentication.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MilVetIndApi.Authentication.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
