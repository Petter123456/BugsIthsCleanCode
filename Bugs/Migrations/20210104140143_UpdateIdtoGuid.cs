using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bugs.Migrations
{
    public partial class UpdateIdtoGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BugModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BugModel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BugModel",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[,]
                {
                    { new Guid("665c4b6e-4e13-427c-85af-c3881d54c4f4"), "no Image", false },
                    { new Guid("79de8c49-e0e5-4fd0-b238-84a16a63e26f"), "no price", false },
                    { new Guid("a39d188d-5925-4690-9669-90a6f98ca2cc"), "no name", false },
                    { new Guid("762f327b-4d7f-46cc-aea0-4ba213da9eed"), "no descriptive text", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BugModel");
        }
    }
}
