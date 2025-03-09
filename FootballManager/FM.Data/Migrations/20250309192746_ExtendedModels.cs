using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FM.Data.Migrations
{
	/// <inheritdoc />
	public partial class ExtendedModels : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropForeignKey(
				name: "FK_Teams_User_UserId",
				table: "Teams");

			migrationBuilder.DropIndex(
				name: "IX_Teams_UserId",
				table: "Teams");

			migrationBuilder.DropColumn(
				name: "UserId",
				table: "Teams");

			migrationBuilder.AddColumn<bool>(
				name: "IsActive",
				table: "User",
				type: "bit",
				nullable: false,
				defaultValue: false);

			migrationBuilder.AddColumn<string>(
				name: "City",
				table: "Teams",
				type: "nvarchar(max)",
				nullable: false,
				defaultValue: "");

			migrationBuilder.AddColumn<DateTime>(
				name: "CreatedAt",
				table: "Teams",
				type: "datetime2",
				nullable: false,
				defaultValueSql: "getutcdate()");

			migrationBuilder.AddColumn<decimal>(
				name: "Earnings",
				table: "Teams",
				type: "decimal(19,2)",
				nullable: false,
				defaultValue: 0m);

			migrationBuilder.AddColumn<bool>(
				name: "IsActive",
				table: "Teams",
				type: "bit",
				nullable: false,
				defaultValue: false);

			migrationBuilder.AlterColumn<string>(
				name: "Nationality",
				table: "Athletes",
				type: "varchar(30)",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "nvarchar(max)");

			migrationBuilder.AlterColumn<string>(
				name: "LastName",
				table: "Athletes",
				type: "varchar(30)",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "nvarchar(max)");

			migrationBuilder.AlterColumn<string>(
				name: "FirstName",
				table: "Athletes",
				type: "varchar(30)",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "nvarchar(max)");

			migrationBuilder.AddColumn<DateTime>(
				name: "CreatedAt",
				table: "Athletes",
				type: "datetime2",
				nullable: false,
				defaultValueSql: "getutcdate()");

			migrationBuilder.AddColumn<bool>(
				name: "IsActive",
				table: "Athletes",
				type: "bit",
				nullable: false,
				defaultValue: false);

			migrationBuilder.AddColumn<decimal>(
				name: "MarketValue",
				table: "Athletes",
				type: "decimal(19,2)",
				nullable: false,
				defaultValue: 0m);

			migrationBuilder.CreateTable(
				name: "Transfers",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					AthleteId = table.Column<int>(type: "int", nullable: false),
					TeamId = table.Column<int>(type: "int", nullable: false),
					TransferValue = table.Column<decimal>(type: "decimal(19,2)", nullable: false),
					CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()")
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Transfers", x => x.Id);
					table.ForeignKey(
						name: "FK_Transfers_Athletes_AthleteId",
						column: x => x.AthleteId,
						principalTable: "Athletes",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Transfers_Teams_TeamId",
						column: x => x.TeamId,
						principalTable: "Teams",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -49,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -48,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -47,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -46,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -45,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -44,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -43,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -42,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -41,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -40,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -39,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -38,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -37,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -36,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -35,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -34,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -33,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -32,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -31,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -30,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -29,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -28,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -27,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -26,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -25,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -24,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -23,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -22,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -21,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -20,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -19,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -18,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -17,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -16,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -15,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -14,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -13,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -12,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -11,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -10,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -9,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -8,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -7,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -6,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -5,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -4,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -3,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -2,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.UpdateData(
				table: "Athletes",
				keyColumn: "Id",
				keyValue: -1,
				columns: new[] { "IsActive", "MarketValue" },
				values: new object[] { true, 0m });

			migrationBuilder.CreateIndex(
				name: "IX_Transfers_AthleteId",
				table: "Transfers",
				column: "AthleteId");

			migrationBuilder.CreateIndex(
				name: "IX_Transfers_TeamId",
				table: "Transfers",
				column: "TeamId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Transfers");

			migrationBuilder.DropColumn(
				name: "IsActive",
				table: "User");

			migrationBuilder.DropColumn(
				name: "City",
				table: "Teams");

			migrationBuilder.DropColumn(
				name: "CreatedAt",
				table: "Teams");

			migrationBuilder.DropColumn(
				name: "Earnings",
				table: "Teams");

			migrationBuilder.DropColumn(
				name: "IsActive",
				table: "Teams");

			migrationBuilder.DropColumn(
				name: "CreatedAt",
				table: "Athletes");

			migrationBuilder.DropColumn(
				name: "IsActive",
				table: "Athletes");

			migrationBuilder.DropColumn(
				name: "MarketValue",
				table: "Athletes");

			migrationBuilder.AddColumn<int>(
				name: "UserId",
				table: "Teams",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AlterColumn<string>(
				name: "Nationality",
				table: "Athletes",
				type: "nvarchar(max)",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "varchar(30)");

			migrationBuilder.AlterColumn<string>(
				name: "LastName",
				table: "Athletes",
				type: "nvarchar(max)",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "varchar(30)");

			migrationBuilder.AlterColumn<string>(
				name: "FirstName",
				table: "Athletes",
				type: "nvarchar(max)",
				nullable: false,
				oldClrType: typeof(string),
				oldType: "varchar(30)");

			migrationBuilder.CreateIndex(
				name: "IX_Teams_UserId",
				table: "Teams",
				column: "UserId");

			migrationBuilder.AddForeignKey(
				name: "FK_Teams_User_UserId",
				table: "Teams",
				column: "UserId",
				principalTable: "User",
				principalColumn: "Id",
				onDelete: ReferentialAction.Cascade);
		}
	}
}
