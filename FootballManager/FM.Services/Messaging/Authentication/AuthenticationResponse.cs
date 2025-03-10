using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Services.Messaging.Authentication
{
	public class AuthenticationResponse
	{
		public string? Token { get; set; }

		public string? Error { get; set; }

		public string? Message { get; set; }
	}
}
