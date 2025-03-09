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
				Position = AthletePosition.Forward
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Erling",
				LastName = "Haaland",
				Nationality = "Norway",
				Position = AthletePosition.Forward
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Kylian",
				LastName = "Mbappe",
				Nationality = "France",
				Position = AthletePosition.Forward
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Vinicius",
				LastName = "Junior",
				Nationality = "Brazil",
				Position = AthletePosition.LeftWing
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Luis",
				LastName = "Diaz",
				Nationality = "Columbia",
				Position = AthletePosition.LeftWing
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Khvicha",
				LastName = "Kvaratskhelia",
				Nationality = "Brazil",
				Position = AthletePosition.LeftWing
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Lamine",
				LastName = "Yamal",
				Nationality = "Spain",
				Position = AthletePosition.RightWing
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Bukayo",
				LastName = "Saka",
				Nationality = "England",
				Position = AthletePosition.RightWing
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Phil",
				LastName = "Foden",
				Nationality = "England",
				Position = AthletePosition.RightWing
			},
			#endregion

			#region Midfielders
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Jude",
				LastName = "Bellingham",
				Nationality = "England",
				Position = AthletePosition.AttackingMidfield
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Florian",
				LastName = "Wirtz",
				Nationality = "Germany",
				Position = AthletePosition.AttackingMidfield
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Jamal",
				LastName = "Musiala",
				Nationality = "Germany",
				Position = AthletePosition.AttackingMidfield
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Cole",
				LastName = "Palmer",
				Nationality = "England",
				Position = AthletePosition.AttackingMidfield
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Federico",
				LastName = "Valverde",
				Nationality = "Uruguay",
				Position = AthletePosition.CenterMidfield
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Declan",
				LastName = "Rice",
				Nationality = "England",
				Position = AthletePosition.CenterMidfield
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Eduardo",
				LastName = "Camavinga",
				Nationality = "France",
				Position = AthletePosition.CenterMidfield
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Alexis",
				LastName = "Mac Allister",
				Nationality = "Argentina",
				Position = AthletePosition.CenterMidfield
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Nicolo",
				LastName = "Barella",
				Nationality = "Italy",
				Position = AthletePosition.CenterMidfield
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Enzo",
				LastName = "Fernandez",
				Nationality = "Argentina",
				Position = AthletePosition.CenterMidfield
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Dominik",
				LastName = "Szoboszlai",
				Nationality = "Hungary",
				Position = AthletePosition.CenterMidfield
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Moises",
				LastName = "Caicedo",
				Nationality = "Ecuador",
				Position = AthletePosition.DefensiveMidfield
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Bruno",
				LastName = "Guimaraes",
				Nationality = "Brazil",
				Position = AthletePosition.DefensiveMidfield
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Aurélien",
				LastName = "Tchouaméni",
				Nationality = "France",
				Position = AthletePosition.DefensiveMidfield
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Joao",
				LastName = "Neves",
				Nationality = "Portugal",
				Position = AthletePosition.DefensiveMidfield
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Martin",
				LastName = "Zubimendi",
				Nationality = "Spain",
				Position = AthletePosition.DefensiveMidfield
			},

			#endregion

			#region Defenders
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "William",
				LastName = "Saliba",
				Nationality = "France",
				Position = AthletePosition.Centerback
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Josko",
				LastName = "Gvardiol",
				Nationality = "Croatia",
				Position = AthletePosition.LeftFullback
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Gabriel",
				LastName = "Magalhaes",
				Nationality = "Brazil",
				Position = AthletePosition.Centerback
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Alessandro",
				LastName = "Bastoni",
				Nationality = "Italy",
				Position = AthletePosition.Centerback
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Trent",
				LastName = "Alexander-Arnold",
				Nationality = "England",
				Position = AthletePosition.RightFullback
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Ruben",
				LastName = "Dias",
				Nationality = "Portugal",
				Position = AthletePosition.Centerback
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Pau",
				LastName = "Cubarsi",
				Nationality = "Spain",
				Position = AthletePosition.Centerback
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Cristian",
				LastName = "Romero",
				Nationality = "Argentina",
				Position = AthletePosition.Centerback
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Jules",
				LastName = "Kounde",
				Nationality = "France",
				Position = AthletePosition.RightFullback
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Achraf",
				LastName = "Hakimi",
				Nationality = "Morroco",
				Position = AthletePosition.RightFullback
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Federico",
				LastName = "Dimarco",
				Nationality = "Italy",
				Position = AthletePosition.LeftFullback
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Nunu",
				LastName = "Mendes",
				Nationality = "Portugal",
				Position = AthletePosition.LeftFullback
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Alejandro",
				LastName = "Balde",
				Nationality = "Spain",
				Position = AthletePosition.LeftFullback
			},
			#endregion

			#region Goalkeepers
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Giorgi",
				LastName = "Mamardashvilli",
				Nationality = "Georgia",
				Position = AthletePosition.Goalkeeper
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Diogo",
				LastName = "Costa",
				Nationality = "Portugal",
				Position = AthletePosition.Goalkeeper
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "David",
				LastName = "Raya",
				Nationality = "Spain",
				Position = AthletePosition.Goalkeeper
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Gregor",
				LastName = "Kobel",
				Nationality = "Switzerland",
				Position = AthletePosition.Goalkeeper
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Gianluigi",
				LastName = "Donnarumma",
				Nationality = "Italy",
				Position = AthletePosition.Goalkeeper
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Guglielmo",
				LastName = "Vicario",
				Nationality = "Italy",
				Position = AthletePosition.Goalkeeper
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Andre",
				LastName = "Onana",
				Nationality = "Cameroon",
				Position = AthletePosition.Goalkeeper
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Mike",
				LastName = "Maignan",
				Nationality = "France",
				Position = AthletePosition.Goalkeeper
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Lucas",
				LastName = "Chevalier",
				Nationality = "France",
				Position = AthletePosition.Goalkeeper
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Unai",
				LastName = "Simon",
				Nationality = "Spain",
				Position = AthletePosition.Goalkeeper
			},
			new Athlete()
			{
				Id = idCounter--,
				FirstName = "Anatoliy",
				LastName = "Trubin",
				Nationality = "Ukraine",
				Position = AthletePosition.Goalkeeper
			}
			#endregion
		];
	}
}
