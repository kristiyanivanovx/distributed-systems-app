namespace FM.Services.Messaging.Requests
{
	public class CreateAthleteRequest : ServiceRequestBase
	{
		public AthleteModel Athlete { get; set; }

		public CreateAthleteRequest(AthleteModel athlete)
		{
			Athlete = athlete;
		}
	}
}
