using Newtonsoft.Json;
using FM.Services;
using FM.Services.Messaging.Responses;
using FM.Data.Entities;
using Spectre.Console;
using Spectre.Console.Cli;
using FM.Services.Messaging.Requests;
using System.Text;
using FM.Services.Messaging;
using Azure.Core;
using System.Web;
using FM.Services.Messaging.Authentication;
using FM.Data.Enums;

namespace FM.GUI
{
	public class Program
	{
		static HttpClient client = new HttpClient();
		
		const string baseUrl = "https://localhost:7073/api/";
		const string athletesControllerUrl = "athletes";

		static string token = null;

		static async Task Main(string[] args)
		{
			

			bool exit = false;
			while(!exit)
			{
				AnsiConsole.MarkupLine("Welcome to [lime]Football Manager[/]! Select an option: ");
				AnsiConsole.MarkupLine("1. Register");
				AnsiConsole.MarkupLine("2. Login");
				AnsiConsole.MarkupLine("3. Athletes");
				AnsiConsole.MarkupLine("4. Teams");
				AnsiConsole.MarkupLine("5. Transfers");
				AnsiConsole.MarkupLine("6. Exit");

				string userInput = AnsiConsole.Ask<string>("Choose option: ");

				switch(userInput) 
				{
					case "1":
					{
						await HandleRegister();
						break;
					}
					case "2":
					{
						await HandleLogin();
						break;
					}
					case "3":
					{
						await HandleAthletes();
						break;
					}
					case "6":
					{
						exit = true;
						break;
					}
				}
			}
		}

		static async Task HandleRegister()
		{
			var username = AnsiConsole.Ask<string>("Enter username: ");
			var password = AnsiConsole.Prompt(
				new TextPrompt<string>("Enter password: ")
					.Secret());

			var query = HttpUtility.ParseQueryString(string.Empty);
			query["username"] = username;
			query["password"] = password;
			string queryString = query.ToString();


			var response = await client.PostAsync(baseUrl + $"auth/register?{queryString}", null);

			string responseBody = await response.Content.ReadAsStringAsync();

			AuthenticationResponse responseDeserialsed = JsonConvert.DeserializeObject<AuthenticationResponse>(responseBody);

			if(responseDeserialsed.Error is not null) 
			{
				AnsiConsole.MarkupLine($"[red]{responseDeserialsed.Error}[/]");
				return;
			}

			AnsiConsole.MarkupLine($"[green]User registered successfully![/]");
			token = responseDeserialsed.Token;
		}
		static async Task HandleLogin()
		{
			var username = AnsiConsole.Ask<string>("Enter username: ");
			var password = AnsiConsole.Prompt(
				new TextPrompt<string>("Enter password: ")
					.Secret());

			var query = HttpUtility.ParseQueryString(string.Empty);
			query["username"] = username;
			query["password"] = password;
			string queryString = query.ToString();


			var response = await client.PutAsync(baseUrl + $"auth?{queryString}", null);

			string responseBody = await response.Content.ReadAsStringAsync();

			AuthenticationResponse responseDeserialsed = JsonConvert.DeserializeObject<AuthenticationResponse>(responseBody);

			if (responseDeserialsed.Error is not null)
			{
				AnsiConsole.MarkupLine($"[red]{responseDeserialsed.Error}[/]");
				return;
			}

			AnsiConsole.MarkupLine($"[green]User logged in successfully![/]");
			token = responseDeserialsed.Token;
		}
		static async Task HandleAthletes()
		{
			AnsiConsole.MarkupLine("Athlete menu. Select an option: ");
			AnsiConsole.MarkupLine("1. Get all athletes");
			AnsiConsole.MarkupLine("2. Get athlete by name");
			AnsiConsole.MarkupLine("3. Create athlete");
			AnsiConsole.MarkupLine("4. Update athlete");
			AnsiConsole.MarkupLine("5. Delete athlete");
			AnsiConsole.MarkupLine("6. Back");

			string userInput = AnsiConsole.Ask<string>("Choose option: ");

			switch (userInput)
			{
				case "1":
				{
					var response = await client.GetAsync(baseUrl + athletesControllerUrl);
					
					string responseBody = await response.Content.ReadAsStringAsync();

					GetAllAthletesResponse responseDeserialsed = JsonConvert.DeserializeObject<GetAllAthletesResponse>(responseBody);


					Table table = new Table();
					table.Border = TableBorder.Square;
					table.ShowRowSeparators = true;

					table.AddColumns("[bold yellow]#[/]", "[bold yellow]First Name[/]", "[bold yellow]Last Name[/]", "[bold yellow]Nationality[/]", "[bold yellow]Market Value[/]");
					for(int i = 0; i < responseDeserialsed.Athletes.Count; i++)
					{
						AthleteViewModel athlete = responseDeserialsed.Athletes[i];
						table.AddRow(
							new Markup((i+1).ToString()), 
							new Markup(athlete.FirstName), 
							new Markup(athlete.LastName), 
							new Markup(athlete.Nationality),
							new Markup("0"));
					}
					AnsiConsole.Write(table);
					break;
				}
				case "2":
				{
					AnsiConsole.Markup("Athlete name: ");
					string athleteName = Console.ReadLine();

					var response = await client.GetAsync(baseUrl + $"{athletesControllerUrl}/{athleteName}");

					string responseBody = await response.Content.ReadAsStringAsync();

					GetByNameResponse responseDeserialsed = JsonConvert.DeserializeObject<GetByNameResponse>(responseBody);

					Table table = new Table();
					table.Border = TableBorder.Square;
					table.ShowRowSeparators = true;

					table.AddColumns( 
						"[bold yellow]First Name[/]", 
						"[bold yellow]Last Name[/]", 
						"[bold yellow]Nationality[/]", 
						"[bold yellow]Market Value[/]"
					);
					AthleteViewModel athlete = responseDeserialsed.Athlete;
					table.AddRow(
						new Markup(athlete.FirstName),
						new Markup(athlete.LastName),
						new Markup(athlete.Nationality),
						new Markup("0"));

					AnsiConsole.Write(table);
					break;
				}
				case "3":
				{
						var athleteFirstName = AnsiConsole.Ask<string>("Athlete first name: ");
						var athleteLastName = AnsiConsole.Ask<string>("Athlete last name: ");
						var athleteNationality = AnsiConsole.Ask<string>("Athlete nationality: ");
						var athleteMarketValue = AnsiConsole.Ask<decimal>("Athlete market value: ");
						var athletePosition = AnsiConsole.Prompt(
							new TextPrompt<string>("Athlete postion: ")
								.AddChoices(["GK", "LB", "RB", "CB", "DM", "CM", "AM", "LW", "RW", "FW"]));

						AthletePosition position = athletePosition switch
						{
							"GK" => AthletePosition.Goalkeeper,
							"LB" => AthletePosition.LeftFullback,
							"RB" => AthletePosition.RightFullback,
							"CB" => AthletePosition.Centerback,
							"DM" => AthletePosition.DefensiveMidfield,
							"CM" => AthletePosition.CenterMidfield,
							"AM" => AthletePosition.AttackingMidfield,
							"LW" => AthletePosition.LeftWing,
							"RW" => AthletePosition.RightWing,
							"FW" => AthletePosition.Forward,
							_ => throw new ArgumentException("Unknown type of a athlete postion", nameof(athletePosition))
						};

						AthleteCreateModel athlete = new AthleteCreateModel()
						{
							FirstName = athleteFirstName,
							LastName = athleteLastName,
							Nationality = athleteNationality,
						};

						var httpContent = new StringContent(JsonConvert.SerializeObject(athlete), Encoding.UTF8, "application/json");

						var response = await client.PostAsync(baseUrl + athletesControllerUrl, httpContent);

						string responseBody = await response.Content.ReadAsStringAsync();

						CreateAthleteResponse responseDeserialsed = JsonConvert.DeserializeObject<CreateAthleteResponse>(responseBody);

						switch (responseDeserialsed.StatusCode)
						{
							case BusinessStatusCodeEnum.Success:
								{
									AnsiConsole.MarkupLine("[green]Athlete created successfully![/]");
									break;
								}
							case BusinessStatusCodeEnum.InternalServerError:
								{
									AnsiConsole.MarkupLine($"[red]Internal server error. Athlete creation failed.[/]");
									break;
								}
							default:
								{
									AnsiConsole.MarkupLine($"[yellow]Unexpected response from server. Athlete creation may have failed.[/]");
									break;
								}
						}


						break;
				}
				case "4":
					{
						var athleteId = AnsiConsole.Ask<string>("Athlete id: ");

						var athleteFirstName = AnsiConsole.Ask<string>("Athlete first name: ");
						var athleteLastName = AnsiConsole.Ask<string>("Athlete last name: ");
						var athleteNationality = AnsiConsole.Ask<string>("Athlete nationality: ");
						var athleteMarketValue = AnsiConsole.Ask<decimal>("Athlete market value: ");
						var athletePosition = AnsiConsole.Prompt(
							new TextPrompt<string>("Athlete postion: ")
								.AddChoices(["GK", "LB", "RB", "CB", "DM", "CM", "AM", "LW", "RW", "FW"]));

						AthletePosition position = athletePosition switch
						{
							"GK" => AthletePosition.Goalkeeper,
							"LB" => AthletePosition.LeftFullback,
							"RB" => AthletePosition.RightFullback,
							"CB" => AthletePosition.Centerback,
							"DM" => AthletePosition.DefensiveMidfield,
							"CM" => AthletePosition.CenterMidfield,
							"AM" => AthletePosition.AttackingMidfield,
							"LW" => AthletePosition.LeftWing,
							"RW" => AthletePosition.RightWing,
							"FW" => AthletePosition.Forward,
							_ => throw new ArgumentException("Unknown type of a athlete postion", nameof(athletePosition))
						};

						UpdateAthleteRequest request = new UpdateAthleteRequest(new AthleteUpdateModel()
						{
							FirstName = athleteFirstName,
							LastName = athleteLastName,
							Nationality = athleteNationality,
						});

						var httpContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

						var response = await client.PutAsync(baseUrl + $"{athletesControllerUrl}/{athleteId}", httpContent);

						string responseBody = await response.Content.ReadAsStringAsync();

						UpdateAthleteResponse responseDeserialsed = JsonConvert.DeserializeObject<UpdateAthleteResponse>(responseBody);

						switch(responseDeserialsed.StatusCode)
						{
							case BusinessStatusCodeEnum.Success:
							{
								AnsiConsole.MarkupLine("[green]Athlete updated successfully![/]");
								break;
							}
							case BusinessStatusCodeEnum.MissingObject:
							{
								AnsiConsole.MarkupLine($"[red]Athlete not found with id of {athleteId}. Athlete update failed.[/]");
								break;
							}
							case BusinessStatusCodeEnum.InternalServerError:
							{
								AnsiConsole.MarkupLine($"[red]Internal server error. Athlete update failed.[/]");
								break;
							}
							default:
							{
								AnsiConsole.MarkupLine($"[yellow]Unexpected response from server. Athlete update may have failed.[/]");
								break;
							}
						}


						break;
					}
				case "5":
					{
						var athleteId = AnsiConsole.Ask<string>("Athlete id: ");

						var response = await client.DeleteAsync(baseUrl + $"{athletesControllerUrl}/{athleteId}");

						string responseBody = await response.Content.ReadAsStringAsync();

						DeleteAthleteResponse responseDeserialsed = JsonConvert.DeserializeObject<DeleteAthleteResponse>(responseBody);
						
						switch (responseDeserialsed.StatusCode)
						{
							case BusinessStatusCodeEnum.Success:
								{
									AnsiConsole.MarkupLine("[green]Athlete deletion successfully![/]");
									break;
								}
							case BusinessStatusCodeEnum.MissingObject:
								{
									AnsiConsole.MarkupLine($"[red]Athlete not found with id of {athleteId}. Athlete deletion failed.[/]");
									break;
								}
							case BusinessStatusCodeEnum.InternalServerError:
								{
									AnsiConsole.MarkupLine($"[red]Internal server error. Athlete deletion failed.[/]");
									break;
								}
							default:
								{
									AnsiConsole.MarkupLine($"[yellow]Unexpected response from server. Athlete deletion may have failed.[/]");
									break;
								}
						}

						break;
					}
				case "6": 
					{ 
						break; 
					}
			}
		}
		static void HandleTeams()
		{

		}
		static void HandleTransfers()
		{

		}
	}
}
