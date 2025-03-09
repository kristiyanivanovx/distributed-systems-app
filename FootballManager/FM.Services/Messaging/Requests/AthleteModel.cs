using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FM.Data.Entities.Athlete;

namespace FM.Services.Messaging.Requests
{
    public class AthleteModel
    {
        required public string FirstName { get; set; }

        required public string LastName { get; set; }

        public string Nationality { get; set; }

        //public AthletePosition Position { get; set; }
    }
}
