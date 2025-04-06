using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Requests
{
    internal abstract class PagedRequest : Request
    {
        public uint PageSize { get; set; } = Configuration.DefaultPageSize;
        public uint PageNumber { get; set; } = Configuration.DefaultPageNumber;
    }
}
