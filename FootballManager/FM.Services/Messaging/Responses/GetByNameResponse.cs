using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FM.Services.Messaging.Responses
{
    public class GetByNameResponse : ServiceResponseBase
    {
        [JsonIgnore]
        public AthleteViewModel? Athlete { get; set; }
    }
}
