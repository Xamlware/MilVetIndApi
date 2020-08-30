using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MilVetIndApi.Migrations
{
    public partial class UpdateEmployeeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "SalesItem");

            migrationBuilder.AlterColumn<string>(
                name: "Address1",
                table: "Employee",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "FK_Country",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Employee",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Employee",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameSuffix",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Employee",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    PK_Sale = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_Sale", x => x.PK_Sale);
                });

            migrationBuilder.CreateTable(
                name: "SaleItem",
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
                    table.PrimaryKey("PK_SaleItem", x => x.PK_SalesItem);
                });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "PK_Employee",
                keyValue: 1,
                columns: new[] { "Address", "City", "Email", "EmployeeId", "FK_Country", "FirstName", "LastName", "MiddleName", "NameSuffix", "ZipCode" },
                values: new object[] { "5000B Newport Road", "Kinzers", "jbaird@outlook.com", "FS1", 1, "Charles", "Baird", "John", "", "17535" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "SaleItem");

            migrationBuilder.DropColumn(
                name: "FK_Country",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "NameSuffix",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Employee");

            migrationBuilder.AlterColumn<string>(
                name: "Address1",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    PK_Sales = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FK_Store = table.Column<int>(type: "int", nullable: false),
                    Payment = table.Column<int>(type: "int", nullable: false),
                    SalesDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tax = table.Column<float>(type: "real", nullable: false),
                    TotalSales = table.Column<float>(type: "real", nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.PK_Sales);
                });

            migrationBuilder.CreateTable(
                name: "SalesItem",
                columns: table => new
                {
                    PK_SalesItem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discount = table.Column<float>(type: "real", nullable: false),
                    FK_Inventory = table.Column<int>(type: "int", nullable: false),
                    FK_Sales = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Quantity = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesItem", x => x.PK_SalesItem);
                });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "PK_Employee",
                keyValue: 1,
                columns: new[] { "Address", "City", "Email", "EmployeeId" },
                values: new object[] { "", "", "", "" });
        }
    }
}
