using System.Text.Json.Serialization;

namespace FM.Services.Messaging.Responses
{
	public class GetByNameResponse : ServiceResponseBase
	{
		[JsonIgnore]
		public AthleteViewModel? Athlete { get; set; }
	}
}
