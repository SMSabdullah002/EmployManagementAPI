using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employ",
                columns: table => new
                {
                    EmployID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employ", x => x.EmployID);
                });

            migrationBuilder.InsertData(
                table: "Employ",
                columns: new[] { "EmployID", "Email", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { 1, "John.smith@gmail.com", "John", 0, "Smith" },
                    { 2, "Joe1987@gmail.com", "Joe", 0, "Gabrial" },
                    { 3, "StrangerThings234@gmail.com", "Will", 0, "Hamster" },
                    { 4, "Shela.Bhabi@gmail.com", "shela", 1, "Barber" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employ");
        }
    }
}
