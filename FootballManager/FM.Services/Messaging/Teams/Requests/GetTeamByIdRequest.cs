using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Services.Messaging.Teams.Requests
{
	public class GetTeamByIdRequest : ServiceRequestBase
	{
		public int Id { get; set; }

		public GetTeamByIdRequest(int id)
		{
			Id = id;
		}
	}
}
