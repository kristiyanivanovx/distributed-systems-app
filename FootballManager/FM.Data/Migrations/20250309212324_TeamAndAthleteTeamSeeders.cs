using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FM.Data.Migrations
{
    /// <inheritdoc />
    public partial class TeamAndAthleteTeamSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Teams",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "City", "Earnings", "IsActive", "Name" },
                values: new object[,]
                {
                    { -5, "Sofia", 5000000m, true, "Levski Sofia" },
                    { -4, "Manchester", 14000000000m, true, "Manchester City" },
                    { -3, "Porto", 2000000000m, true, "Porto" },
                    { -2, "Madrid", 16000000000m, true, "Real Madrid" },
                    { -1, "Barcelona", 13000000000m, true, "Barcelona" }
                });

            migrationBuilder.InsertData(
                table: "AthleteTeam",
                columns: new[] { "Id", "AthleteId", "TeamId" },
                values: new object[,]
                {
                    { -48, -48, -3 },
                    { -47, -47, -2 },
                    { -46, -46, -2 },
                    { -45, -45, -4 },
                    { -44, -44, -3 },
                    { -43, -43, -2 },
                    { -42, -42, -3 },
                    { -41, -41, -2 },
                    { -40, -40, -2 },
                    { -39, -39, -4 },
                    { -38, -38, -1 },
                    { -37, -37, -2 },
                    { -36, -36, -1 },
                    { -35, -35, -4 },
                    { -34, -34, -3 },
                    { -33, -33, -5 },
                    { -32, -32, -3 },
                    { -31, -31, -3 },
                    { -30, -30, -2 },
                    { -29, -29, -2 },
                    { -28, -28, -2 },
                    { -27, -27, -1 },
                    { -26, -26, -3 },
                    { -25, -25, -1 },
                    { -24, -24, -2 },
                    { -23, -23, -4 },
                    { -22, -22, -1 },
                    { -21, -21, -4 },
                    { -20, -20, -2 },
                    { -19, -19, -5 },
                    { -18, -18, -5 },
                    { -17, -17, -3 },
                    { -16, -16, -4 },
                    { -15, -15, -2 },
                    { -14, -14, -1 },
                    { -13, -13, -2 },
                    { -12, -12, -3 },
                    { -11, -11, -5 },
                    { -10, -10, -2 },
                    { -9, -9, -2 },
                    { -8, -8, -1 },
                    { -7, -7, -5 },
                    { -6, -6, -4 },
                    { -5, -5, -5 },
                    { -4, -4, -1 },
                    { -3, -3, -4 },
                    { -2, -2, -1 },
                    { -1, -1, -5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");
        }
    }
}
