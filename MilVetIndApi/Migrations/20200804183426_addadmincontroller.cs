using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MilVetIndApi.Migrations
{
    public partial class addadmincontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    PK_District = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_Region = table.Column<int>(nullable: false),
                    DistrictName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.PK_District);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    PK_Employee = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_Store = table.Column<int>(nullable: false),
                    FK_State = table.Column<int>(nullable: false),
                    FK_Race = table.Column<int>(nullable: false),
                    FK_Gender = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<string>(nullable: false),
                    AspUserId = table.Column<string>(nullable: false),
                    EmployeeName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Address1 = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.PK_Employee);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTime",
                columns: table => new
                {
                    PK_EmployeeTime = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_Store = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<string>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTime", x => x.PK_EmployeeTime);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    PK_Gender = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.PK_Gender);
                });

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    PK_Race = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaceName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.PK_Race);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    PK_Region = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.PK_Region);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    PK_Sales = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_Store = table.Column<int>(nullable: false),
                    SalesDate = table.Column<DateTime>(nullable: false),
                    TotalSales = table.Column<float>(nullable: false),
                    Tax = table.Column<float>(nullable: false),
                    Payment = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<string>(nullable: false),
                    TransactionId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.PK_Sales);
                });

            migrationBuilder.CreateTable(
                name: "SalesItem",
                columns: table => new
                {
                    PK_SalesItem = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_Sales = table.Column<int>(nullable: false),
                    FK_Inventory = table.Column<int>(nullable: false),
                    Quantity = table.Column<float>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    Discount = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesItem", x => x.PK_SalesItem);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    PK_State = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(nullable: false),
                    Abbreviation = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.PK_State);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    PK_Store = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_District = table.Column<int>(nullable: false),
                    StoreName = table.Column<string>(nullable: false),
                    StoreAbbreviation = table.Column<string>(nullable: false),
                    LastId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.PK_Store);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "PK_District", "DistrictName", "FK_Region" },
                values: new object[] { 1, "District 1", 1 });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "PK_Employee", "Address", "Address1", "AspUserId", "City", "Email", "EmployeeId", "EmployeeName", "FK_Gender", "FK_Race", "FK_State", "FK_Store" },
                values: new object[] { 1, "", "", "", "", "", "", "Employee 1", 1, 1, 38, 1 });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "PK_Gender", "GenderName" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" },
                    { 3, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Race",
                columns: new[] { "PK_Race", "RaceName" },
                values: new object[,]
                {
                    { 7, "Pacific Islander" },
                    { 6, "Native Hawaiian" },
                    { 5, "Asian" },
                    { 8, "Other" },
                    { 3, "American Indian" },
                    { 2, "Black" },
                    { 1, "White" },
                    { 4, "Native Alaskan" }
                });

            migrationBuilder.InsertData(
                table: "Region",
                columns: new[] { "PK_Region", "RegionName" },
                values: new object[] { 1, "Region 1" });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "PK_State", "Abbreviation", "StateName" },
                values: new object[,]
                {
                    { 37, "OR", "Oregon" },
                    { 28, "NV", "Nevada" },
                    { 29, "NH", "New Hampshire" },
                    { 30, "NJ", "New Jersey" },
                    { 31, "NM", "New Mexico" },
                    { 32, "NY", "New York" },
                    { 33, "NC", "North Carolina" },
                    { 34, "ND", "North Dakota" },
                    { 35, "OH", "Ohio" },
                    { 36, "OK", "Oklahoma" },
                    { 38, "PA", "Penssylvania" },
                    { 45, "VT", "Vermont" },
                    { 40, "SC", "South Carolina" },
                    { 41, "SD", "South Dakota" },
                    { 42, "TN", "Tennesee" },
                    { 43, "TX", "Texas" },
                    { 44, "UT", "Utah" },
                    { 27, "NE", "Nebraska" },
                    { 46, "VA", "Virginia" },
                    { 47, "WA", "Washington" },
                    { 48, "WV", "West Virginia" },
                    { 49, "WI", "Wisconsin" },
                    { 39, "RI", "Rhode Island" },
                    { 26, "MT", "Montana" },
                    { 19, "ME", "Maine" },
                    { 24, "MI", "Mississippi" },
                    { 1, "AL", "Alabama" },
                    { 2, "AK", "Alaska" },
                    { 3, "AZ", "Arizona" },
                    { 4, "AR", "Arkansas" },
                    { 5, "AL", "California" },
                    { 6, "CO", "Colorado" },
                    { 7, "CT", "Connecticut" },
                    { 8, "DE", "Delaware" },
                    { 9, "FL", "Florida" },
                    { 10, "GA", "Georgia" },
                    { 11, "HI", "Hawaii" },
                    { 12, "ID", "Idaho" },
                    { 13, "IL", "Illinois" },
                    { 14, "IN", "Indiana" },
                    { 15, "IA", "Iowa" },
                    { 16, "KS", "Kansas" },
                    { 17, "KY", "Kentucky" },
                    { 18, "LA", "Louisiana" },
                    { 50, "WY", "Wyoming" },
                    { 20, "MD", "Maryland" },
                    { 21, "MA", "Massachusetts" },
                    { 22, "MI", "Michigan" },
                    { 23, "MN", "Minnesota" },
                    { 25, "MO", "Missouri" }
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "PK_Store", "FK_District", "LastId", "StoreAbbreviation", "StoreName" },
                values: new object[] { 1, 1, 0, "FS", "First Store" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "EmployeeTime");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Race");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "SalesItem");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
