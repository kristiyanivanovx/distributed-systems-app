using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Services.Messaging.Requests
{
    public class GetAthleteRequest : ServiceRequestBase
    {
        public string Name { get; set; }

        public GetAthleteRequest(string name)
        {
            Name = name;
        }
    }
}
