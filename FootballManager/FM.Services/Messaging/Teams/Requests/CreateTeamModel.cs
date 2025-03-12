namespace FM.Services.Messaging.Teams.Responses
{
	public class CreateTeamModel
	{
		public required string Name { get; set; }

		public required string City { get; set; }

		public decimal Earnings { get; set; }
	}
}
