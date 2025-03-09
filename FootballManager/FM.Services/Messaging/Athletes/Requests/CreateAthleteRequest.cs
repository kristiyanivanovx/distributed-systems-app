namespace FM.Services.Messaging.Requests
{
	public class CreateAthleteRequest : ServiceRequestBase
	{
		public AthleteCreateModel Athlete { get; set; }

		public CreateAthleteRequest(AthleteCreateModel athlete)
		{
			Athlete = athlete;
		}
	}
}
