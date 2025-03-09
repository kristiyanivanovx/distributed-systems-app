using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Services.Messaging.Responses
{
    public class GetAllAthletesResponse : ServiceResponseBase
    {
        public List<AthleteViewModel> Athletes { get; set; }
    }
}
