namespace FM.Services.Messaging.Responses
{
	public class GetAllAthletesResponse : ServiceResponseBase
	{
		public List<AthleteViewModel> Athletes { get; set; }
	}
}
