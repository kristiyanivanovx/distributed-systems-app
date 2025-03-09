using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Services.Messaging.Requests
{
    public class CreateAthleteRequest : ServiceRequestBase
    {
        public AthleteModel Athlete { get; set; }

        public CreateAthleteRequest(AthleteModel athlete)
        {
            Athlete = athlete;
        }
    }
}
