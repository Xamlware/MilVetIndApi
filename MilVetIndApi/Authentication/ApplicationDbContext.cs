using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MilVetIndApi.Data;

namespace MilVetIndApi.Authentication
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Race
            builder.Entity<Race>().HasData(new Race { PK_Race = 1, RaceName = "White" });
            builder.Entity<Race>().HasData(new Race { PK_Race = 2, RaceName = "Black" });
            builder.Entity<Race>().HasData(new Race { PK_Race = 3, RaceName = "American Indian" });
            builder.Entity<Race>().HasData(new Race { PK_Race = 4, RaceName = "Native Alaskan" });
            builder.Entity<Race>().HasData(new Race { PK_Race = 5, RaceName = "Asian" });
            builder.Entity<Race>().HasData(new Race { PK_Race = 6, RaceName = "Native Hawaiian" });
            builder.Entity<Race>().HasData(new Race { PK_Race = 7, RaceName = "Pacific Islander" });
            builder.Entity<Race>().HasData(new Race { PK_Race = 8, RaceName = "Other" });

            //Gender
            builder.Entity<Gender>().HasData(new Gender { PK_Gender = 1, GenderName = "Male" });
            builder.Entity<Gender>().HasData(new Gender { PK_Gender = 2, GenderName = "Female" });
            builder.Entity<Gender>().HasData(new Gender { PK_Gender = 3, GenderName = "Other" });

            //District
            builder.Entity<District>().HasData(new District { PK_District = 1, DistrictName = "District 1" });

            //District
            builder.Entity<Store>().HasData(new Store { PK_Store = 1, StoreName = "First Store", FK_District=1, LastId= 0, StoreAbbreviation="FS" });

            //Region
            builder.Entity<Region>().HasData(new Region { PK_Region = 1, RegionName = "Region 1" });

            //Employee
            builder.Entity<Employee>().HasData(new Employee { PK_Employee = 1, FK_Store=1, FK_Gender=1,
                FK_Race=1, FK_State=38, Address="", Address1="", AspUserId="",
                City="", Email="", EmployeeId="", EmployeeName = "Employee 1" });

        //state
        builder.Entity<State>().HasData(
                new State { PK_State = 1, StateName = "Alabama", Abbreviation = "AL" },
                new State { PK_State = 2, StateName = "Alaska", Abbreviation = "AK" },
                new State { PK_State = 3, StateName = "Arizona", Abbreviation = "AZ" },
                new State { PK_State = 4, StateName = "Arkansas", Abbreviation = "AR" },
                new State { PK_State = 5, StateName = "California", Abbreviation = "AL" },
                new State { PK_State = 6, StateName = "Colorado", Abbreviation = "CO" },
                new State { PK_State = 7, StateName = "Connecticut", Abbreviation = "CT" },
                new State { PK_State = 8, StateName = "Delaware", Abbreviation = "DE" },
                new State { PK_State = 9, StateName = "Florida", Abbreviation = "FL" },
                new State { PK_State = 10, StateName = "Georgia", Abbreviation = "GA" },
                new State { PK_State = 11, StateName = "Hawaii", Abbreviation = "HI" },
                new State { PK_State = 12, StateName = "Idaho", Abbreviation = "ID" },
                new State { PK_State = 13, StateName = "Illinois", Abbreviation = "IL" },
                new State { PK_State = 14, StateName = "Indiana", Abbreviation = "IN" },
                new State { PK_State = 15, StateName = "Iowa", Abbreviation = "IA" },
                new State { PK_State = 16, StateName = "Kansas", Abbreviation = "KS" },
                new State { PK_State = 17, StateName = "Kentucky", Abbreviation = "KY" },
                new State { PK_State = 18, StateName = "Louisiana", Abbreviation = "LA" },
                new State { PK_State = 19, StateName = "Maine", Abbreviation = "ME" },
                new State { PK_State = 20, StateName = "Maryland", Abbreviation = "MD" },
                new State { PK_State = 21, StateName = "Massachusetts", Abbreviation = "MA" },
                new State { PK_State = 22, StateName = "Michigan", Abbreviation = "MI" },
                new State { PK_State = 23, StateName = "Minnesota", Abbreviation = "MN" },
                new State { PK_State = 24, StateName = "Mississippi", Abbreviation = "MI" },
                new State { PK_State = 25, StateName = "Missouri", Abbreviation = "MO" },
                new State { PK_State = 26, StateName = "Montana", Abbreviation = "MT" },
                new State { PK_State = 27, StateName = "Nebraska", Abbreviation = "NE" },
                new State { PK_State = 28, StateName = "Nevada", Abbreviation = "NV" },
                new State { PK_State = 29, StateName = "New Hampshire", Abbreviation = "NH" },
                new State { PK_State = 30, StateName = "New Jersey", Abbreviation = "NJ" },
                new State { PK_State = 31, StateName = "New Mexico", Abbreviation = "NM" },
                new State { PK_State = 32, StateName = "New York", Abbreviation = "NY" },
                new State { PK_State = 33, StateName = "North Carolina", Abbreviation = "NC" },
                new State { PK_State = 34, StateName = "North Dakota", Abbreviation = "ND" },
                new State { PK_State = 35, StateName = "Ohio", Abbreviation = "OH" },
                new State { PK_State = 36, StateName = "Oklahoma", Abbreviation = "OK" },
                new State { PK_State = 37, StateName = "Oregon", Abbreviation = "OR" },
                new State { PK_State = 38, StateName = "Penssylvania", Abbreviation = "PA" },
                new State { PK_State = 39, StateName = "Rhode Island", Abbreviation = "RI" },
                new State { PK_State = 40, StateName = "South Carolina", Abbreviation = "SC" },
                new State { PK_State = 41, StateName = "South Dakota", Abbreviation = "SD" },
                new State { PK_State = 42, StateName = "Tennesee", Abbreviation = "TN" },
                new State { PK_State = 43, StateName = "Texas", Abbreviation = "TX" },
                new State { PK_State = 44, StateName = "Utah", Abbreviation = "UT" },
                new State { PK_State = 45, StateName = "Vermont", Abbreviation = "VT" },
                new State { PK_State = 46, StateName = "Virginia", Abbreviation = "VA" },
                new State { PK_State = 47, StateName = "Washington", Abbreviation = "WA" },
                new State { PK_State = 48, StateName = "West Virginia", Abbreviation = "WV" },
                new State { PK_State = 49, StateName = "Wisconsin", Abbreviation = "WI" },
                new State { PK_State = 50, StateName = "Wyoming", Abbreviation = "WY" });
        }

        public DbSet<District> District { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Race> Race { get; set; }
        //public DbSet<User> User { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<StoreSales> StoreSales { get; set; }
        public DbSet<StoreSalesItem> StoreSalesItem { get; set; }
    }
}