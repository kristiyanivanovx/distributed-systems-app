namespace FM.Services.Messaging.Requests
{
	public class AthleteModel
	{
    public int Id { get; set; }
    
		required public string FirstName { get; set; }

		required public string LastName { get; set; }

		public string Nationality { get; set; }

		//public AthletePosition Position { get; set; }
	}
}
