using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FM.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialAthleteSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Athletes",
                columns: new[] { "Id", "FirstName", "LastName", "Nationality", "Position" },
                values: new object[] { -1, "Cristiano", "Ronaldo", "Portugal", 7 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
