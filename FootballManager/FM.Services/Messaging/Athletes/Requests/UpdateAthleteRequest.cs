using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Services.Messaging.Requests
{
    public class UpdateAthleteRequest : ServiceRequestBase
    {

        public AthleteUpdateModel Athlete { get; set; }

        public UpdateAthleteRequest(AthleteUpdateModel athlete)
        {
            Athlete = athlete;
        }
    }
}
