using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Services.Interfaces
{
    public interface IJWTAuthenticationsManager
    {
        string? Authenticate(string clientId, string secret);
    }
}
