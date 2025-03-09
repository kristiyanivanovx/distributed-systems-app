using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FM.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedAthleteSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Athletes",
                columns: new[] { "Id", "FirstName", "LastName", "Nationality", "Position" },
                values: new object[,]
                {
                    { -49, "Anatoliy", "Trubin", "Ukraine", 0 },
                    { -48, "Unai", "Simon", "Spain", 0 },
                    { -47, "Lucas", "Chevalier", "France", 0 },
                    { -46, "Mike", "Maignan", "France", 0 },
                    { -45, "Andre", "Onana", "Cameroon", 0 },
                    { -44, "Guglielmo", "Vicario", "Italy", 0 },
                    { -43, "Gianluigi", "Donnarumma", "Italy", 0 },
                    { -42, "Gregor", "Kobel", "Switzerland", 0 },
                    { -41, "David", "Raya", "Spain", 0 },
                    { -40, "Diogo", "Costa", "Portugal", 0 },
                    { -39, "Giorgi", "Mamardashvilli", "Georgia", 0 },
                    { -38, "Alejandro", "Balde", "Spain", 2 },
                    { -37, "Nunu", "Mendes", "Portugal", 2 },
                    { -36, "Federico", "Dimarco", "Italy", 2 },
                    { -35, "Achraf", "Hakimi", "Morroco", 1 },
                    { -34, "Jules", "Kounde", "France", 1 },
                    { -33, "Cristian", "Romero", "Argentina", 3 },
                    { -32, "Pau", "Cubarsi", "Spain", 3 },
                    { -31, "Ruben", "Dias", "Portugal", 3 },
                    { -30, "Trent", "Alexander-Arnold", "England", 1 },
                    { -29, "Alessandro", "Bastoni", "Italy", 3 },
                    { -28, "Gabriel", "Magalhaes", "Brazil", 3 },
                    { -27, "Josko", "Gvardiol", "Croatia", 2 },
                    { -26, "William", "Saliba", "France", 3 },
                    { -25, "Martin", "Zubimendi", "Spain", 6 },
                    { -24, "Joao", "Neves", "Portugal", 6 },
                    { -23, "Aurélien", "Tchouaméni", "France", 6 },
                    { -22, "Bruno", "Guimaraes", "Brazil", 6 },
                    { -21, "Moises", "Caicedo", "Ecuador", 6 },
                    { -20, "Dominik", "Szoboszlai", "Hungary", 4 },
                    { -19, "Enzo", "Fernandez", "Argentina", 4 },
                    { -18, "Nicolo", "Barella", "Italy", 4 },
                    { -17, "Alexis", "Mac Allister", "Argentina", 4 },
                    { -16, "Eduardo", "Camavinga", "France", 4 },
                    { -15, "Declan", "Rice", "England", 4 },
                    { -14, "Federico", "Valverde", "Uruguay", 4 },
                    { -13, "Cole", "Palmer", "England", 5 },
                    { -12, "Jamal", "Musiala", "Germany", 5 },
                    { -11, "Florian", "Wirtz", "Germany", 5 },
                    { -10, "Jude", "Bellingham", "England", 5 },
                    { -9, "Phil", "Foden", "England", 9 },
                    { -8, "Bukayo", "Saka", "England", 9 },
                    { -7, "Lamine", "Yamal", "Spain", 9 },
                    { -6, "Khvicha", "Kvaratskhelia", "Brazil", 8 },
                    { -5, "Luis", "Diaz", "Columbia", 8 },
                    { -4, "Vinicius", "Junior", "Brazil", 8 },
                    { -3, "Kylian", "Mbappe", "France", 7 },
                    { -2, "Erling", "Haaland", "Norway", 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Athletes",
                keyColumn: "Id",
                keyValue: -2);
        }
    }
}
