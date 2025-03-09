namespace FM.Services.Messaging.Responses
{
    public class AthleteViewModel
    {
    public int Id { get; set; }

    required public string FirstName { get; set; }

    required public string LastName { get; set; }

		public string Nationality { get; set; }

		// public AthletePosition Position { get; set; }
	}
}
