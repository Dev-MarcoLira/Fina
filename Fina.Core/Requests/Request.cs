using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Requests
{
    internal abstract class Request
    {
        public string UserId { get; set; } = string.Empty;
    }
}
