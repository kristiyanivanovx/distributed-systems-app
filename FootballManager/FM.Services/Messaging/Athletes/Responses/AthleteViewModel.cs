namespace FM.Services.Messaging.Responses
{
	public class AthleteViewModel
	{
		public int Id { get; set; }

		required public string FirstName { get; set; }

		required public string LastName { get; set; }

		public string Nationality { get; set; }

		public decimal MarketValue { get; set; }

		public int? TeamId { get; set; }

		public string? TeamName { get; set; }
	}
}
