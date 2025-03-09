using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Services.Messaging.Requests
{
    public class GetByNameRequest : ServiceRequestBase
    {
        public string Name { get; set; }

        public GetByNameRequest(string name)
        {
            Name = name;
        }
    }
}
