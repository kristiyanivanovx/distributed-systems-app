using System.Text.Json.Serialization;

namespace FM.Services.Messaging
{
	public class ServiceResponseError : ServiceResponseBase
	{
		[JsonIgnore]
		public string? DeveloperError { get; set; }

		required public string Message { get; set; }

		public ServiceResponseError() : base(BusinessStatusCodeEnum.InternalServerError) { }
	}
}
