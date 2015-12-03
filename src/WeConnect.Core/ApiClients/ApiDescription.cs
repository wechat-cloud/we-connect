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
            FormKeyValues = new Dictionary<string, string>();
        }

        public string Resource { get; set; }
        public IDictionary<string, string> QueryParameters { get; }
        public HttpMethod Method { get; set; } = HttpMethod.Get;

        public IDictionary<string, string> FormKeyValues { get; set; }

        public FileDescription File { get; set; }
    }
}
