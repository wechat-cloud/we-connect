using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeConnect.Core
{
    public class ApiDescriptionBuilder
    {
        internal ApiDescription Build()
        {
            throw new NotImplementedException();
        }

        public ApiDescriptionBuilder UseResource(string resource)
        {
            throw new NotImplementedException();
        }

        public ApiDescriptionBuilder UseHttp()
        {
            throw new NotImplementedException();
        }

        public ApiDescriptionBuilder UseHttps()
        {
            throw new NotImplementedException();
        }

        public ApiDescriptionBuilder UseMethod(HttpMethod post)
        {
            throw new NotImplementedException();
        }

        public ApiDescriptionBuilder Body(object p)
        {
            throw new NotImplementedException();
        }

        public ApiDescriptionBuilder Json<T>(T target)
        {
            throw new NotImplementedException();
        }

        public ApiDescriptionBuilder UseParameter(string pKey, string pValue)
        {
            throw new NotImplementedException();
        }

        public ApiDescriptionBuilder File(string key, string fileName, Stream fileStream)
        {
            throw new NotImplementedException();
        }
    }
}
