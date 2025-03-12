using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Services.Messaging.Authentication
{
	public class JWTResponseOrError : ServiceResponseBase
	{
		public ServiceResponseOptionalGenericError? Error { get; set; }

		public string? Token { get; set; }

		public JWTResponseOrError()
		{
			Error = null;
			Token = null;
		}

		public JWTResponseOrError(BusinessStatusCodeEnum statusCode) : base(statusCode) { }

		public JWTResponseOrError(BusinessStatusCodeEnum errorCode, string errorMessage)
		{
			Error = new ServiceResponseOptionalGenericError(errorCode) { Message = errorMessage };
		}
	}
}
