using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FM.Data.Migrations
{
    /// <inheritdoc />
    public partial class TransferIsActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Transfers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -49,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -48,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -47,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -46,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -45,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -44,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -43,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -42,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -41,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -40,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -37,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -36,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -35,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -34,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -33,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -32,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -31,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -30,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -29,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -28,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -27,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -26,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -24,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -23,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -21,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -17,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -16,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -15,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -14,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -13,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -11,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -10,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -9,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -8,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -7,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -6,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -5,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -4,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -3,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -1,
                column: "TeamId",
                value: -4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Transfers");

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -49,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -48,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -47,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -46,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -45,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -44,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -43,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -42,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -41,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -40,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -37,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -36,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -35,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -34,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -33,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -32,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -31,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -30,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -29,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -28,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -27,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -26,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -24,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -23,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -21,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -17,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -16,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -15,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -14,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -13,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -11,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -10,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -9,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -8,
                column: "TeamId",
                value: -5);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -7,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -6,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -5,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -4,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -3,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -1,
                column: "TeamId",
                value: -2);
        }
    }
}
