using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Services.Messaging.Responses
{
    public class AthleteViewModel
    {
        required public string FirstName { get; set; }
        
        required public string LastName { get; set; }

        public string Nationality { get; set; }

        // public AthletePosition Position { get; set; }
    }
}
