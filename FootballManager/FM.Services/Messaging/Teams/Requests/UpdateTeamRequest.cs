using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Services.Messaging.Teams.Requests
{
	public class UpdateTeamRequest
    {
        public string? Name { get; set; }

        public string? City { get; set; }

        public decimal? Earnings { get; set; }
    }
}
