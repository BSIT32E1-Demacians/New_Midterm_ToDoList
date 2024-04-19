using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Midterm_ToDoList.Migrations
{
    /// <inheritdoc />
    public partial class AppDbContextModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NToDo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Done = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NToDo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "NToDo",
                columns: new[] { "Id", "Category", "Description", "Done" },
                values: new object[] { 1, "Activity", "Generating Art", false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NToDo");
        }
    }
}
