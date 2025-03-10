using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FM.Services.Messaging
{
	public class ServiceResponseGenericError : ServiceResponseBase
	{
		[JsonIgnore]
		public string? DeveloperError { get; set; }

		required public string Message { get; set; }

		public ServiceResponseGenericError(BusinessStatusCodeEnum errorCode) : base(errorCode) { }
	}
}
