using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeConnect.Core
{
    public class ApiDescription
    {
        private string baseUrl = string.Empty;
        public ApiDescription()
        {
            QueryParameters = new Dictionary<string, string>();
            FormKeyValues = new Dictionary<string, string>();
            Files = new Dictionary<string, FileDescription>();

            UseHttpsProtocal();
        }

        public string Resource { get; internal set; }
        public IDictionary<string, string> QueryParameters { get; private set; }
        public HttpMethod Method { get; internal set; } = HttpMethod.Get;

        public IDictionary<string, string> FormKeyValues { get; private set; }
        public object JsonBody { get; private set; }

        public IDictionary<string, FileDescription> Files { get; private set; }

        internal void UseHttpProtocal()
        {
            baseUrl = "http://api.weixin.qq.com";
        }

        internal void UseHttpsProtocal()
        {
            baseUrl = "https://api.weixin.qq.com";
        }

        internal void AddFormKeyValue(string pKey, string pValue) {
            if (JsonBody != null) {
                throw new InvalidOperationException("cannot set both values of FormKeyValue & JsonBody");
            }

            FormKeyValues.Add(pKey, pValue);
        }

        internal void SetJsonBody(object obj) {
            if (FormKeyValues.Any()) {
                throw new InvalidOperationException("cannot set both values of FormKeyValue & JsonBody");
            }

            JsonBody = obj;
        }
    }
}
