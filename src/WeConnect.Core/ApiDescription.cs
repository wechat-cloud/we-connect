using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeConnect.Core
{
    public class ApiDescription
    {
        public ApiDescription()
        {
            QueryParameters = new Dictionary<string, string>();
        }

        public string ResourceTemplate { get; set; }
        public IDictionary<string, string> QueryParameters { get; }
        public HttpMethod Method { get; set; } = HttpMethod.Get;
    }
}
