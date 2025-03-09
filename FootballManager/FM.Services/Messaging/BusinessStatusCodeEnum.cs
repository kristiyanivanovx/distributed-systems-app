using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Services.Messaging
{
    public enum BusinessStatusCodeEnum
    {
        None = 0,
        Success = 200,
        MissingObject = 404,
        InternalServerError = 500,
    }
}
