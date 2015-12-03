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
        private ApiDescription _apiDescription = new ApiDescription();
        internal ApiDescriptionBuilder()
        {

        }

        internal ApiDescription Build()
        {
            return _apiDescription;
        }

        public ApiDescriptionBuilder UseResource(string resource)
        {
            return this;
        }

        public ApiDescriptionBuilder UseHttp()
        {
            return this;
        }

        public ApiDescriptionBuilder UseHttps()
        {
            return this;
        }

        public ApiDescriptionBuilder UseGet() {
            return UseMethod(HttpMethod.Get);
        }

        public ApiDescriptionBuilder UsePost()
        {
            return UseMethod(HttpMethod.Post);
        }

        public ApiDescriptionBuilder UseMethod(HttpMethod post)
        {
            return this;
        }

        public ApiDescriptionBuilder Body(object p)
        {
            return this;
        }

        public ApiDescriptionBuilder Json<T>(T target)
        {
            return this;
        }

        public ApiDescriptionBuilder UseParameter(string pKey, string pValue)
        {
            return this;
        }

        public ApiDescriptionBuilder File(string key, string fileName, Stream fileStream)
        {
            return this;
        }
    }
}
