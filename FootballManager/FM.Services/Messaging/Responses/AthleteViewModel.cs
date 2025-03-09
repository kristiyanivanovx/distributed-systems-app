namespace FM.Services.Messaging.Responses
{
	public class AthleteViewModel
	{
		required public string FirstName { get; set; }

		required public string LastName { get; set; }

		public string Nationality { get; set; }

		// public AthletePosition Position { get; set; }
	}
}
