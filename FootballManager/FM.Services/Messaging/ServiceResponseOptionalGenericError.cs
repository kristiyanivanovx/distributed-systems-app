using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FM.Services.Messaging
{
	public class ServiceResponseOptionalGenericError : ServiceResponseBase
	{
		[JsonIgnore]
		public string? DeveloperError { get; set; }

		public string? Message { get; set; }

		public ServiceResponseOptionalGenericError(BusinessStatusCodeEnum errorCode) : base(errorCode) { }

		public ServiceResponseOptionalGenericError()
		{

		}
	}
}
