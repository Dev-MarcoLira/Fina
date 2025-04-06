using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Fina.Core.Responses
{
    internal class PagedResponse<TData> : Response<TData>
    {
        [JsonConstructor]
        public PagedResponse(
            TData? data,
            int totalCount,
            int currentPage = 1,
            uint pageSize = Configuration.DefaultPageSize
        ) : base(data)
        {
            Data = data;
            TotalCount = totalCount;
            CurrentPage = currentPage;
            PageSize = pageSize;
        }

        public PagedResponse
        (
            TData? data,
            int code = Configuration.DefaultStatusCode,
            string? message = null
        ) : base(data, code, message)
        { }
        public int CurrentPage { get; set; }
        public int TotalPages => (int) Math.Ceiling(
            TotalCount / (double) PageSize);
        public uint PageSize { get; set; } = Configuration.DefaultPageSize;
        public int TotalCount { get; set; }


    }
}
