using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AG.Book.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Created", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Anthony Burgess", new DateTime(2022, 4, 9, 22, 46, 38, 283, DateTimeKind.Local).AddTicks(8299), "Otomatik Portakal", 20m },
                    { 2, "Anthony Burgess", new DateTime(2022, 4, 9, 22, 46, 38, 283, DateTimeKind.Local).AddTicks(8313), "Otomatik Portakal", 20m },
                    { 3, "Anthony Burgess", new DateTime(2022, 4, 9, 22, 46, 38, 283, DateTimeKind.Local).AddTicks(8316), "Otomatik Portakal", 20m },
                    { 4, "Anthony Burgess", new DateTime(2022, 4, 9, 22, 46, 38, 283, DateTimeKind.Local).AddTicks(8319), "Otomatik Portakal", 20m },
                    { 5, "Anthony Burgess", new DateTime(2022, 4, 9, 22, 46, 38, 283, DateTimeKind.Local).AddTicks(8321), "Otomatik Portakal", 20m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
