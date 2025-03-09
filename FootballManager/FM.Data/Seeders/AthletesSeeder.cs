using FM.Data.Entities;
using static FM.Data.Entities.Athlete;

namespace FM.Data.Seeders;
public class AthletesSeeder : ISeeder<Athlete>
{
	private int idCounter;

	public AthletesSeeder()
	{
		idCounter = -1;
	}

	public IEnumerable<Athlete> Seed()
	{
		return [
			#region Forwards
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Cristiano",
				LastName = "Ronaldo",
				Nationality = "Portugal",
				Position = AthletePosition.Forward,
				MarketValue = 200000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Erling",
				LastName = "Haaland",
				Nationality = "Norway",
				Position = AthletePosition.Forward
				,
				MarketValue = 250000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Kylian",
				LastName = "Mbappe",
				Nationality = "France",
				Position = AthletePosition.Forward,
				MarketValue = 230000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Vinicius",
				LastName = "Junior",
				Nationality = "Brazil",
				Position = AthletePosition.LeftWing,
				MarketValue = 100000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Luis",
				LastName = "Diaz",
				Nationality = "Columbia",
				Position = AthletePosition.LeftWing,
				MarketValue = 110000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Khvicha",
				LastName = "Kvaratskhelia",
				Nationality = "Brazil",
				Position = AthletePosition.LeftWing,
				MarketValue = 200000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Lamine",
				LastName = "Yamal",
				Nationality = "Spain",
				Position = AthletePosition.RightWing,
				MarketValue = 180000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Bukayo",
				LastName = "Saka",
				Nationality = "England",
				Position = AthletePosition.RightWing,
				MarketValue = 150000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Phil",
				LastName = "Foden",
				Nationality = "England",
				Position = AthletePosition.RightWing,
				MarketValue = 160000000
			},
			#endregion

			#region Midfielders
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Jude",
				LastName = "Bellingham",
				Nationality = "England",
				Position = AthletePosition.AttackingMidfield,
				MarketValue = 1400000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Florian",
				LastName = "Wirtz",
				Nationality = "Germany",
				Position = AthletePosition.AttackingMidfield,
				MarketValue = 120000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Jamal",
				LastName = "Musiala",
				Nationality = "Germany",
				Position = AthletePosition.AttackingMidfield,
				MarketValue = 100000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Cole",
				LastName = "Palmer",
				Nationality = "England",
				Position = AthletePosition.AttackingMidfield,
				MarketValue = 90000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Federico",
				LastName = "Valverde",
				Nationality = "Uruguay",
				Position = AthletePosition.CenterMidfield,
				MarketValue = 800000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Declan",
				LastName = "Rice",
				Nationality = "England",
				Position = AthletePosition.CenterMidfield,
				MarketValue = 100000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Eduardo",
				LastName = "Camavinga",
				Nationality = "France",
				Position = AthletePosition.CenterMidfield,
				MarketValue = 140000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Alexis",
				LastName = "Mac Allister",
				Nationality = "Argentina",
				Position = AthletePosition.CenterMidfield,
				MarketValue = 130000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Nicolo",
				LastName = "Barella",
				Nationality = "Italy",
				Position = AthletePosition.CenterMidfield,
				MarketValue = 110000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Enzo",
				LastName = "Fernandez",
				Nationality = "Argentina",
				Position = AthletePosition.CenterMidfield,
				MarketValue = 100000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Dominik",
				LastName = "Szoboszlai",
				Nationality = "Hungary",
				Position = AthletePosition.CenterMidfield,
				MarketValue = 90000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Moises",
				LastName = "Caicedo",
				Nationality = "Ecuador",
				Position = AthletePosition.DefensiveMidfield,
				MarketValue = 80000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Bruno",
				LastName = "Guimaraes",
				Nationality = "Brazil",
				Position = AthletePosition.DefensiveMidfield,
				MarketValue = 750000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Aurélien",
				LastName = "Tchouaméni",
				Nationality = "France",
				Position = AthletePosition.DefensiveMidfield,
				MarketValue = 890000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Joao",
				LastName = "Neves",
				Nationality = "Portugal",
				Position = AthletePosition.DefensiveMidfield,
				MarketValue = 132000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Martin",
				LastName = "Zubimendi",
				Nationality = "Spain",
				Position = AthletePosition.DefensiveMidfield,
				MarketValue = 120000000
			},

			#endregion

			#region Defenders
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "William",
				LastName = "Saliba",
				Nationality = "France",
				Position = AthletePosition.Centerback,
				MarketValue = 120000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Josko",
				LastName = "Gvardiol",
				Nationality = "Croatia",
				Position = AthletePosition.LeftFullback,
				MarketValue = 120000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Gabriel",
				LastName = "Magalhaes",
				Nationality = "Brazil",
				Position = AthletePosition.Centerback,
				MarketValue = 160000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Alessandro",
				LastName = "Bastoni",
				Nationality = "Italy",
				Position = AthletePosition.Centerback,
				MarketValue = 136000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Trent",
				LastName = "Alexander-Arnold",
				Nationality = "England",
				Position = AthletePosition.RightFullback,
				MarketValue = 74000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Ruben",
				LastName = "Dias",
				Nationality = "Portugal",
				Position = AthletePosition.Centerback,
				MarketValue = 112000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Pau",
				LastName = "Cubarsi",
				Nationality = "Spain",
				Position = AthletePosition.Centerback,
				MarketValue = 102000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Cristian",
				LastName = "Romero",
				Nationality = "Argentina",
				Position = AthletePosition.Centerback,
				MarketValue = 102000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Jules",
				LastName = "Kounde",
				Nationality = "France",
				Position = AthletePosition.RightFullback,
				MarketValue = 130000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Achraf",
				LastName = "Hakimi",
				Nationality = "Morroco",
				Position = AthletePosition.RightFullback,
				MarketValue = 82000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Federico",
				LastName = "Dimarco",
				Nationality = "Italy",
				Position = AthletePosition.LeftFullback,
				MarketValue = 67000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Nunu",
				LastName = "Mendes",
				Nationality = "Portugal",
				Position = AthletePosition.LeftFullback,
				MarketValue = 102000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Alejandro",
				LastName = "Balde",
				Nationality = "Spain",
				Position = AthletePosition.LeftFullback,
				MarketValue = 98000000
			},
			#endregion

			#region Goalkeepers
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Giorgi",
				LastName = "Mamardashvilli",
				Nationality = "Georgia",
				Position = AthletePosition.Goalkeeper,
				MarketValue = 50000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Diogo",
				LastName = "Costa",
				Nationality = "Portugal",
				Position = AthletePosition.Goalkeeper,
				MarketValue = 150000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "David",
				LastName = "Raya",
				Nationality = "Spain",
				Position = AthletePosition.Goalkeeper,
				MarketValue = 102000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Gregor",
				LastName = "Kobel",
				Nationality = "Switzerland",
				Position = AthletePosition.Goalkeeper,
				MarketValue = 102000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Gianluigi",
				LastName = "Donnarumma",
				Nationality = "Italy",
				Position = AthletePosition.Goalkeeper,
				MarketValue = 130000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Guglielmo",
				LastName = "Vicario",
				Nationality = "Italy",
				Position = AthletePosition.Goalkeeper,
				MarketValue = 99000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Andre",
				LastName = "Onana",
				Nationality = "Cameroon",
				Position = AthletePosition.Goalkeeper,
				MarketValue = 104000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Mike",
				LastName = "Maignan",
				Nationality = "France",
				Position = AthletePosition.Goalkeeper,
				MarketValue = 92000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Lucas",
				LastName = "Chevalier",
				Nationality = "France",
				Position = AthletePosition.Goalkeeper,
				MarketValue = 30000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Unai",
				LastName = "Simon",
				Nationality = "Spain",
				Position = AthletePosition.Goalkeeper,
				MarketValue = 540000000
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Anatoliy",
				LastName = "Trubin",
				Nationality = "Ukraine",
				Position = AthletePosition.Goalkeeper,
				MarketValue = 760000000
			}
			#endregion
		];
	}
}
