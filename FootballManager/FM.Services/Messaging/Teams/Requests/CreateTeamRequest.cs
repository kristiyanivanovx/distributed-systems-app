using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FM.Services.Messaging.Requests;
using FM.Services.Messaging.Teams.Responses;

namespace FM.Services.Messaging.Teams.Requests
{
	public class CreateTeamRequest : ServiceRequestBase
	{
		public CreateTeamModel Team { get; set; }

		public CreateTeamRequest(CreateTeamModel team)
		{
			Team = team;
		}
	}
}
