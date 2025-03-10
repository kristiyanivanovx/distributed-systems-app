using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FM.Data.Migrations
{
    /// <inheritdoc />
    public partial class AthleteTeamReplacement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_Teams_TeamId",
                table: "Transfers");

            migrationBuilder.DropTable(
                name: "AthleteTeam");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Transfers",
                newName: "OldTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfers_TeamId",
                table: "Transfers",
                newName: "IX_Transfers_OldTeamId");

            migrationBuilder.AddColumn<int>(
                name: "NewTeamId",
                table: "Transfers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Athletes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                keyValue: -39,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -38,
                column: "TeamId",
                value: -2);

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
                keyValue: -25,
                column: "TeamId",
                value: -1);

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
                keyValue: -22,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -21,
                column: "TeamId",
                value: -3);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -20,
                column: "TeamId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -19,
                column: "TeamId",
                value: -2);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -18,
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
                keyValue: -12,
                column: "TeamId",
                value: -4);

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
                keyValue: -2,
                column: "TeamId",
                value: -4);

            migrationBuilder.UpdateData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -1,
                column: "TeamId",
                value: -2);

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_NewTeamId",
                table: "Transfers",
                column: "NewTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Athletes_TeamId",
                table: "Athletes",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Athletes_Teams_TeamId",
                table: "Athletes",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_Teams_NewTeamId",
                table: "Transfers",
                column: "NewTeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_Teams_OldTeamId",
                table: "Transfers",
                column: "OldTeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Athletes_Teams_TeamId",
                table: "Athletes");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_Teams_NewTeamId",
                table: "Transfers");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_Teams_OldTeamId",
                table: "Transfers");

            migrationBuilder.DropIndex(
                name: "IX_Transfers_NewTeamId",
                table: "Transfers");

            migrationBuilder.DropIndex(
                name: "IX_Athletes_TeamId",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "NewTeamId",
                table: "Transfers");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Athletes");

            migrationBuilder.RenameColumn(
                name: "OldTeamId",
                table: "Transfers",
                newName: "TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfers_OldTeamId",
                table: "Transfers",
                newName: "IX_Transfers_TeamId");

            migrationBuilder.CreateTable(
                name: "AthleteTeam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AthleteId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AthleteTeam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AthleteTeam_Athletes_AthleteId",
                        column: x => x.AthleteId,
                        principalTable: "Athletes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AthleteTeam_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AthleteTeam",
                columns: new[] { "Id", "AthleteId", "TeamId" },
                values: new object[,]
                {
                    { -48, -48, -4 },
                    { -47, -47, -4 },
                    { -46, -46, -1 },
                    { -45, -45, -3 },
                    { -44, -44, -3 },
                    { -43, -43, -2 },
                    { -42, -42, -2 },
                    { -41, -41, -3 },
                    { -40, -40, -2 },
                    { -39, -39, -3 },
                    { -38, -38, -3 },
                    { -37, -37, -1 },
                    { -36, -36, -1 },
                    { -35, -35, -3 },
                    { -34, -34, -4 },
                    { -33, -33, -3 },
                    { -32, -32, -1 },
                    { -31, -31, -2 },
                    { -30, -30, -5 },
                    { -29, -29, -2 },
                    { -28, -28, -4 },
                    { -27, -27, -5 },
                    { -26, -26, -4 },
                    { -25, -25, -3 },
                    { -24, -24, -4 },
                    { -23, -23, -2 },
                    { -22, -22, -5 },
                    { -21, -21, -5 },
                    { -20, -20, -3 },
                    { -19, -19, -3 },
                    { -18, -18, -4 },
                    { -17, -17, -1 },
                    { -16, -16, -3 },
                    { -15, -15, -2 },
                    { -14, -14, -4 },
                    { -13, -13, -4 },
                    { -12, -12, -5 },
                    { -11, -11, -4 },
                    { -10, -10, -3 },
                    { -9, -9, -1 },
                    { -8, -8, -5 },
                    { -7, -7, -4 },
                    { -6, -6, -3 },
                    { -5, -5, -4 },
                    { -4, -4, -1 },
                    { -3, -3, -4 },
                    { -2, -2, -5 },
                    { -1, -1, -2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AthleteTeam_AthleteId",
                table: "AthleteTeam",
                column: "AthleteId");

            migrationBuilder.CreateIndex(
                name: "IX_AthleteTeam_TeamId",
                table: "AthleteTeam",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_Teams_TeamId",
                table: "Transfers",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
