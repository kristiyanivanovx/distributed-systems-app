using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Services.Messaging.Requests
{
	public class AthleteUpdateModel
	{
		public string? FirstName { get; set; }

		public string? LastName { get; set; }

		public string? Nationality { get; set; }

		//public AthletePosition Position { get; set; }
		public decimal? MarketValue { get; set; }

		public int? TeamId { get; set; }
	}
}
