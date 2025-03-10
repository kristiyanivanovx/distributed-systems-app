using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FM.Data.Migrations
{
    /// <inheritdoc />
    public partial class UniqueUsernameIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -48,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -47,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -46,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -45,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -42,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -41,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -39,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -38,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -37,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -35,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -34,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -33,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -32,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -31,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -30,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -28,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -27,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -26,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -25,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -24,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -23,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -22,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -21,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -20,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -19,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -18,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -17,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -16,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -14,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -13,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -12,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -11,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -10,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -9,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -8,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -7,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -6,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -5,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -2,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -1,
                column: "TeamId",
                value: -2);

            migrationBuilder.CreateIndex(
                name: "IX_User_Username",
                table: "User",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_Username",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -48,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -47,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -46,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -45,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -42,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -41,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -39,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -38,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -37,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -35,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -34,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -33,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -32,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -31,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -30,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -28,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -27,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -26,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -25,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -24,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -23,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -22,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -21,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -20,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -19,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -18,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -17,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -16,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -14,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -13,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -12,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -11,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -10,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -9,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -8,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -7,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -6,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -5,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -2,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "AthleteTeam",
                keyColumn: "Id",
                keyValue: -1,
                column: "TeamId",
                value: -5);
        }
    }
}
