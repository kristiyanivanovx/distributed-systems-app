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
using FM.Services.Messaging.Teams.Responses;
using FM.Services.Messaging.Teams.Requests;
using System.Net.Http.Headers;
using System.Net.Http;

namespace FM.GUI
{
	public class Program
	{
		static HttpClient client = new HttpClient();
		
		const string baseUrl = "https://localhost:7073/api/";
		const string athletesControllerUrl = "athletes";
		const string teamControllerUrl = "teams";
		const string transferControllerUrl = "transfers";

		const string UnauthorizedErrorMessage = "[red]Not authorized. Log in to continue[/]";
		const string AlreadyLoggedInErrorMessage = "[red]Already logged in.[/]";

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

				AnsiConsole.Clear();

				switch (userInput) 
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
					case "4":
					{
						await HandleTeams();
						break;
					}
					case "5":
					{
						await HandleTransfers();
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
			if (token is not null)
			{
				AnsiConsole.MarkupLine(AlreadyLoggedInErrorMessage);
				return;
			}
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
			client.DefaultRequestHeaders.Authorization
						 = new AuthenticationHeaderValue("Bearer", token);
		}
		static async Task HandleLogin()
		{
			if (token is not null)
			{
				AnsiConsole.MarkupLine(AlreadyLoggedInErrorMessage);
				return;
			}

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
			client.DefaultRequestHeaders.Authorization
						 = new AuthenticationHeaderValue("Bearer", token);
		}
		static async Task HandleAthletes()
		{
			bool back = false;
			while (!back)
			{
				AnsiConsole.MarkupLine("Athlete menu. Select an option: ");
				AnsiConsole.MarkupLine("1. Get all athletes");
				AnsiConsole.MarkupLine("2. Get athlete by name");
				AnsiConsole.MarkupLine(FormatWithAuth("3. Create athlete"));
				AnsiConsole.MarkupLine(FormatWithAuth("4. Update athlete"));
				AnsiConsole.MarkupLine(FormatWithAuth("5. Delete athlete"));
				AnsiConsole.MarkupLine("6. Back");

				string userInput = AnsiConsole.Ask<string>("Choose option: ");

				AnsiConsole.Clear();

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

							table.AddColumns(
								"[bold yellow]#[/]",
								"[bold yellow]First Name[/]",
								"[bold yellow]Last Name[/]",
								"[bold yellow]Nationality[/]",
								"[bold yellow]Team[/]",
								"[bold yellow]Market Value[/]"
							);
							for (int i = 0; i < responseDeserialsed.Athletes.Count; i++)
							{
								AthleteViewModel athlete = responseDeserialsed.Athletes[i];
								table.AddRow(
									new Markup((i + 1).ToString()),
									new Markup(athlete.FirstName),
									new Markup(athlete.LastName),
									new Markup(athlete.Nationality),
									new Markup(athlete.TeamName),
									new Markup(athlete.MarketValue.ToString())
								);
							}
							AnsiConsole.Write(table);
							break;
						}
					case "2":
						{
							AnsiConsole.MarkupLine("Athlete [lime]get by name[/] form");
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
								"[bold yellow]Team[/]",
								"[bold yellow]Market Value[/]"
							);
							AthleteViewModel athlete = responseDeserialsed.Athlete;
							table.AddRow(
								new Markup(athlete.FirstName),
								new Markup(athlete.LastName),
								new Markup(athlete.Nationality),
								new Markup(athlete.TeamName),
								new Markup(athlete.MarketValue.ToString())
							);

							AnsiConsole.Write(table);
							break;
						}
					case "3":
						{
							AnsiConsole.MarkupLine("Athlete [blue]create[/] form");
							if (token is null)
							{
								AnsiConsole.MarkupLine(UnauthorizedErrorMessage);
								break;
							}

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

							var teamResponse = await client.GetAsync(baseUrl + teamControllerUrl);

							string teamResponseBody = await teamResponse.Content.ReadAsStringAsync();

							GetAllTeamsResponse teamResponseDeserialsed = JsonConvert.DeserializeObject<GetAllTeamsResponse>(teamResponseBody);


							Table table = new Table();
							table.Border = TableBorder.Square;
							table.ShowRowSeparators = true;

							table.AddColumns(
								"[bold yellow]#[/]",
								"[bold yellow]Team[/]",
								"[bold yellow]City[/]",
								"[bold yellow]Earnings[/]"
							);
							for (int i = 0; i < teamResponseDeserialsed.Teams.Count; i++)
							{
								TeamViewModel team = teamResponseDeserialsed.Teams[i];
								table.AddRow(
									new Markup((i + 1).ToString()),
									new Markup(team.Name),
									new Markup(team.City),
									new Markup(team.Earnings.ToString())
								);
							}
							AnsiConsole.Write(table);

							int teamChoice = AnsiConsole.Ask<int>("Athlete team: ");

							if (teamChoice - 1 < 0 || teamChoice - 1 >= teamResponseDeserialsed.Teams.Count)
							{
								AnsiConsole.MarkupLine("[red]Chosen team does not exist. Athlete creation canceled.[/]");
								continue;
							} 


							AthleteCreateModel athlete = new AthleteCreateModel()
							{
								FirstName = athleteFirstName,
								LastName = athleteLastName,
								Nationality = athleteNationality,
								MarketValue = athleteMarketValue,
								Position = position,
								TeamId = teamResponseDeserialsed.Teams[teamChoice - 1].Id
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
							AnsiConsole.MarkupLine("Athlete [orange1]update[/] form");
							if (token is null)
							{
								AnsiConsole.MarkupLine(UnauthorizedErrorMessage);
								break;
							}

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

							var teamResponse = await client.GetAsync(baseUrl + teamControllerUrl);

							string teamResponseBody = await teamResponse.Content.ReadAsStringAsync();

							GetAllTeamsResponse teamResponseDeserialsed = JsonConvert.DeserializeObject<GetAllTeamsResponse>(teamResponseBody);

							Table table = new Table();
							table.Border = TableBorder.Square;
							table.ShowRowSeparators = true;

							table.AddColumns(
											"[bold yellow]#[/]",
											"[bold yellow]Team[/]",
											"[bold yellow]City[/]",
											"[bold yellow]Earnings[/]"
							);
							for (int i = 0; i < teamResponseDeserialsed.Teams.Count; i++)
							{
								TeamViewModel team = teamResponseDeserialsed.Teams[i];
								table.AddRow(
												new Markup((i + 1).ToString()),
												new Markup(team.Name),
												new Markup(team.City),
												new Markup(team.Earnings.ToString())
								);
							}
							AnsiConsole.Write(table);

							int teamChoice = AnsiConsole.Ask<int>("Athlete team: ");

							if (teamChoice - 1 < 0 || teamChoice - 1 >= teamResponseDeserialsed.Teams.Count)
							{
								AnsiConsole.MarkupLine("[red]Chosen team does not exist. Athlete creation canceled.[/]");
								continue;
							}


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

							switch (responseDeserialsed.StatusCode)
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
							AnsiConsole.MarkupLine("Athlete [red]delete[/] form");
							if (token is null)
							{
								AnsiConsole.MarkupLine(UnauthorizedErrorMessage);
								break;
							}

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
						back = true;
						break;
					}
				}
			}
		}
		static async Task HandleTeams()
		{
			bool back = false;
			while(!back)
			{
				AnsiConsole.MarkupLine("Team menu. Select an option: ");
				AnsiConsole.MarkupLine("1. Get all teams");
				AnsiConsole.MarkupLine("2. Get team by id");
				AnsiConsole.MarkupLine(FormatWithAuth("3. Create team"));
				AnsiConsole.MarkupLine(FormatWithAuth("4. Update team"));
				AnsiConsole.MarkupLine(FormatWithAuth("5. Delete team"));
				AnsiConsole.MarkupLine("6. Back");

				string userInput = AnsiConsole.Ask<string>("Choose option: ");

				AnsiConsole.Clear();

				switch (userInput)
				{
					case "1":
					{
						var response = await client.GetAsync(baseUrl + teamControllerUrl);

						string responseBody = await response.Content.ReadAsStringAsync();

						GetAllTeamsResponse responseDeserialsed = JsonConvert.DeserializeObject<GetAllTeamsResponse>(responseBody);


						Table table = new Table();
						table.Border = TableBorder.Square;
						table.ShowRowSeparators = true;

						table.AddColumns(
							"[bold yellow]#[/]",
							"[bold yellow]Team[/]",
							"[bold yellow]City[/]",
							"[bold yellow]Earnings[/]"
						);
						for (int i = 0; i < responseDeserialsed.Teams.Count; i++)
						{
							TeamViewModel team = responseDeserialsed.Teams[i];
							table.AddRow(
								new Markup((i + 1).ToString()),
								new Markup(team.Name),
								new Markup(team.City),
								new Markup(team.Earnings.ToString())
							);
						}
						AnsiConsole.Write(table);
						break;
					}
					case "2":
					{
						AnsiConsole.MarkupLine("Team [lime]get by id[/] form");
						string teamId = AnsiConsole.Ask<string>("Team id: ");

						var response = await client.GetAsync(baseUrl + $"{teamControllerUrl}/{teamId}");

						string responseBody = await response.Content.ReadAsStringAsync();

						GetTeamByIdResponse responseDeserialsed = JsonConvert.DeserializeObject<GetTeamByIdResponse>(responseBody);

						Table table = new Table();
						table.Border = TableBorder.Square;
						table.ShowRowSeparators = true;

						table.AddColumns(
							"[bold yellow]Team[/]",
							"[bold yellow]City[/]",
							"[bold yellow]Earnings[/]"
						);
						TeamViewModel team = responseDeserialsed.Team;
						table.AddRow(
							new Markup(team.Name),
							new Markup(team.City),
							new Markup(team.Earnings.ToString())
						);

						AnsiConsole.Write(table);
						break;
					}
					case "3": 
					{
						AnsiConsole.MarkupLine("Team [blue]create[/] form");
						if (token is null)
						{
							AnsiConsole.MarkupLine(UnauthorizedErrorMessage);
							break;
						}

						var teamName = AnsiConsole.Ask<string>("Team name: ");
						var teamCity = AnsiConsole.Ask<string>("Team city: ");
						var teamEarnings = AnsiConsole.Ask<decimal>("Team earnings: ");


						CreateTeamModel team = new CreateTeamModel()
						{
							Name = teamName,
							City = teamCity,
							Earnings = teamEarnings,
						};

						var httpContent = new StringContent(JsonConvert.SerializeObject(team), Encoding.UTF8, "application/json");

						var response = await client.PostAsync(baseUrl + teamControllerUrl, httpContent);

						string responseBody = await response.Content.ReadAsStringAsync();

						CreateTeamResponse responseDeserialsed = JsonConvert.DeserializeObject<CreateTeamResponse>(responseBody);

						switch (responseDeserialsed.StatusCode)
						{
							case BusinessStatusCodeEnum.Success:
								{
									AnsiConsole.MarkupLine("[green]Team created successfully![/]");
									break;
								}
							case BusinessStatusCodeEnum.InternalServerError:
								{
									AnsiConsole.MarkupLine($"[red]Internal server error. Team creation failed.[/]");
									break;
								}
							default:
								{
									AnsiConsole.MarkupLine($"[yellow]Unexpected response from server. Team creation may have failed.[/]");
									break;
								}
						}

						break;
					}
					case "4":
					{
						AnsiConsole.MarkupLine("Team [orange1]update[/] form");
						if (token is null)
						{
							AnsiConsole.MarkupLine(UnauthorizedErrorMessage);
							break;
						}

						var teamId = AnsiConsole.Ask<int>("Team id: ");

						var teamName = AnsiConsole.Ask<string>("Team name: ");
						var teamCity = AnsiConsole.Ask<string>("Team city: ");
						var teamEarnings = AnsiConsole.Ask<decimal>("Team earnings: ");

						UpdateTeamRequest team = new UpdateTeamRequest()
						{
							Name = teamName,
							City = teamCity,
							Earnings = teamEarnings,
						};

						var httpContent = new StringContent(JsonConvert.SerializeObject(team), Encoding.UTF8, "application/json");

						var response = await client.PutAsync(baseUrl + teamControllerUrl + $"/{teamId}", httpContent);

						string responseBody = await response.Content.ReadAsStringAsync();

						UpdateTeamResponse responseDeserialsed = JsonConvert.DeserializeObject<UpdateTeamResponse>(responseBody);

						switch (responseDeserialsed.StatusCode)
						{
							case BusinessStatusCodeEnum.Success:
								{
									AnsiConsole.MarkupLine("[green]Team updated successfully![/]");
									break;
								}
							case BusinessStatusCodeEnum.InternalServerError:
								{
									AnsiConsole.MarkupLine($"[red]Internal server error. Team update failed.[/]");
									break;
								}
							default:
								{
									AnsiConsole.MarkupLine($"[yellow]Unexpected response from server. Team update may have failed.[/]");
									break;
								}
						}
						break;
					}
					case "5":
					{
						AnsiConsole.MarkupLine("Team [red]deletion[/] form");
						if (token is null)
						{
							AnsiConsole.MarkupLine(UnauthorizedErrorMessage);
							break;
						}

						var teamId = AnsiConsole.Ask<string>("Team id: ");

						var response = await client.DeleteAsync(baseUrl + $"{teamControllerUrl}/{teamId}");

						string responseBody = await response.Content.ReadAsStringAsync();

						DeleteTeamResponse responseDeserialsed = JsonConvert.DeserializeObject<DeleteTeamResponse>(responseBody);

						switch (responseDeserialsed.StatusCode)
						{
							case BusinessStatusCodeEnum.Success:
								{
									AnsiConsole.MarkupLine("[green]Team deletion successfully![/]");
									break;
								}
							case BusinessStatusCodeEnum.MissingObject:
								{
									AnsiConsole.MarkupLine($"[red]Team not found with id of {teamId}. Team deletion failed.[/]");
									break;
								}
							case BusinessStatusCodeEnum.InternalServerError:
								{
									AnsiConsole.MarkupLine($"[red]Internal server error. Team deletion failed.[/]");
									break;
								}
							default:
								{
									AnsiConsole.MarkupLine($"[yellow]Unexpected response from server. Team deletion may have failed.[/]");
									break;
								}
						}

						break;
					}
					case "6":
					{
						back = true;
						break;
					}
				}

			}
		}
		static async Task HandleTransfers()
		{
			bool back = false;
			while(!back)
			{
				AnsiConsole.MarkupLine("Transfers menu. Select an option: ");
				AnsiConsole.MarkupLine("1. Get all transfers");
				AnsiConsole.MarkupLine("2. Get transfer by id");
				AnsiConsole.MarkupLine(FormatWithAuth("3. Create transfer"));
				AnsiConsole.MarkupLine(FormatWithAuth("4. Delete transfer"));
				AnsiConsole.MarkupLine("5. Back");

				string userInput = AnsiConsole.Ask<string>("Choose option: ");

				AnsiConsole.Clear();

				switch(userInput)
				{
					case "1":
					{
						var response = await client.GetAsync(baseUrl + transferControllerUrl);

						string responseBody = await response.Content.ReadAsStringAsync();

						GetAllTransfersResponse responseDeserialsed = JsonConvert.DeserializeObject<GetAllTransfersResponse>(responseBody);


						Table table = new Table();
						table.Border = TableBorder.Square;
						table.ShowRowSeparators = true;

						table.AddColumns(
							"[bold yellow]#[/]",
							"[bold yellow]Athlete[/]",
							"[bold yellow]Old Team[/]",
							"[bold yellow]New Team[/]",
							"[bold yellow]Transfer value[/]"
						);
						for (int i = 0; i < responseDeserialsed.Transfers.Count; i++)
						{
							TransferViewModel transfer = responseDeserialsed.Transfers[i];
							table.AddRow(
								new Markup((i + 1).ToString()),
								new Markup(transfer.AthleteName),
								new Markup(transfer.OldTeamName),
								new Markup(transfer.NewTeamName),
								new Markup(transfer.TransferValue.ToString())
							);
						}
						AnsiConsole.Write(table);
						break;
					}
					case "2":
					{
						AnsiConsole.MarkupLine("Transfer [lime]get by id[/] form");
						string transferId = AnsiConsole.Ask<string>("Transfer id: ");

						var response = await client.GetAsync(baseUrl + $"{transferControllerUrl}/{transferId}");

						string responseBody = await response.Content.ReadAsStringAsync();

						GetByIdResponse responseDeserialsed = JsonConvert.DeserializeObject<GetByIdResponse>(responseBody);

						Table table = new Table();
						table.Border = TableBorder.Square;
						table.ShowRowSeparators = true;

						table.AddColumns(
							"[bold yellow]Athlete[/]",
							"[bold yellow]Old Team[/]",
							"[bold yellow]New Team[/]",
							"[bold yellow]Transfer value[/]"
						);
						TransferViewModel transfer = responseDeserialsed.Transfer;
						table.AddRow(
							new Markup(transfer.AthleteName),
							new Markup(transfer.OldTeamName),
							new Markup(transfer.NewTeamName),
							new Markup(transfer.TransferValue.ToString())
						);

						AnsiConsole.Write(table);
						break;
					}
					case "3":
					{
						AnsiConsole.MarkupLine("Transfer [blue]create[/] form");
						if (token is null)
						{
							AnsiConsole.MarkupLine(UnauthorizedErrorMessage);
							break;
						}

						AnsiConsole.Markup("Athlete name: ");
						string athleteName = Console.ReadLine();

						var athleteResponse = await client.GetAsync(baseUrl + $"{athletesControllerUrl}/{athleteName}");

						string athleteResponseBody = await athleteResponse.Content.ReadAsStringAsync();

						GetByNameResponse athleteResponseDeserialsed = JsonConvert.DeserializeObject<GetByNameResponse>(athleteResponseBody);


						var teamResponse = await client.GetAsync(baseUrl + teamControllerUrl);

						string teamResponseBody = await teamResponse.Content.ReadAsStringAsync();

						GetAllTeamsResponse teamResponseDeserialsed = JsonConvert.DeserializeObject<GetAllTeamsResponse>(teamResponseBody);


						Table table = new Table();
						table.Border = TableBorder.Square;
						table.ShowRowSeparators = true;

						table.AddColumns(
							"[bold yellow]#[/]",
							"[bold yellow]Team[/]",
							"[bold yellow]City[/]",
							"[bold yellow]Earnings[/]"
						);
						for (int i = 0; i < teamResponseDeserialsed.Teams.Count; i++)
						{
							TeamViewModel team = teamResponseDeserialsed.Teams[i];
							table.AddRow(
								new Markup((i + 1).ToString()),
								new Markup(team.Name),
								new Markup(team.City),
								new Markup(team.Earnings.ToString())
							);
						}
						AnsiConsole.Write(table);

						int teamChoice = AnsiConsole.Ask<int>("Athlete new team: ");

						if (teamChoice - 1 < 0 || teamChoice - 1 >= teamResponseDeserialsed.Teams.Count)
						{
							AnsiConsole.MarkupLine("[red]Chosen team does not exist. Transfer creation canceled.[/]");
							continue;
						}

						decimal transferValue = AnsiConsole.Ask<decimal>("Transfer value: ");


						TransferCreateModel transfer = new TransferCreateModel()
						{
							AthleteId = athleteResponseDeserialsed.Athlete.Id,
							OldTeamId = (int)athleteResponseDeserialsed.Athlete.TeamId,
							NewTeamId = teamResponseDeserialsed.Teams[teamChoice - 1].Id,
							TransferValue = transferValue
						};

						var httpContent = new StringContent(JsonConvert.SerializeObject(transfer), Encoding.UTF8, "application/json");

						var response = await client.PostAsync(baseUrl + transferControllerUrl, httpContent);

						string responseBody = await response.Content.ReadAsStringAsync();

						CreateTransferResponse responseDeserialsed = JsonConvert.DeserializeObject<CreateTransferResponse>(responseBody);


						switch (responseDeserialsed.StatusCode)
						{
							case BusinessStatusCodeEnum.Success:
								{
									AnsiConsole.MarkupLine("[green]Transfer created successfully![/]");
									break;
								}
							case BusinessStatusCodeEnum.InternalServerError:
								{
									AnsiConsole.MarkupLine($"[red]Internal server error. Transfer creation failed.[/]");
									break;
								}
							default:
								{
									AnsiConsole.MarkupLine($"[yellow]Unexpected response from server. Transfer may have failed.[/]");
									break;
								}
						}

						break;
					}
					case "4":
					{
						AnsiConsole.MarkupLine("Transfer [red]delete[/] form");
						if (token is null)
						{
							AnsiConsole.MarkupLine(UnauthorizedErrorMessage);
							break;
						}

						var transferId = AnsiConsole.Ask<string>("Transfer id: ");

						var response = await client.DeleteAsync(baseUrl + $"{transferControllerUrl}/{transferId}");

						string responseBody = await response.Content.ReadAsStringAsync();

						DeleteTransferResponse responseDeserialsed = JsonConvert.DeserializeObject<DeleteTransferResponse>(responseBody);

						switch (responseDeserialsed.StatusCode)
						{
							case BusinessStatusCodeEnum.Success:
								{
									AnsiConsole.MarkupLine("[green]Transfer deletion successfully![/]");
									break;
								}
							case BusinessStatusCodeEnum.MissingObject:
								{
									AnsiConsole.MarkupLine($"[red]Transfer not found with id of {transferId}. Transfer deletion failed.[/]");
									break;
								}
							case BusinessStatusCodeEnum.InternalServerError:
								{
									AnsiConsole.MarkupLine($"[red]Internal server error. Transfer deletion failed.[/]");
									break;
								}
							default:
								{
									AnsiConsole.MarkupLine($"[yellow]Unexpected response from server. Transfer deletion may have failed.[/]");
									break;
								}
						}
						break;
					}
					case "5":
					{
						back = true;
						break;
					}
				}
			}
		}
	
		static string FormatWithAuth(string text)
		{
			if (token is null) return $"[red]{text} [[Unauthorized]] [/]";
			return text;
		}
	}
}
