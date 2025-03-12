using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Services.Messaging.Teams.Responses
{
	public class TeamViewModel
	{
		public int Id { get; set; }

		public required string Name { get; set; }

		public required string City { get; set; }

		public decimal Earnings { get; set; }
	}
}
