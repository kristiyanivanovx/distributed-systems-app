using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Services.Messaging.Teams.Requests
{
	public class DeleteTeamRequest
	{
		public int Id { get; set; }

		public DeleteTeamRequest(int id)
		{
			Id = id;
		}
	}
}
