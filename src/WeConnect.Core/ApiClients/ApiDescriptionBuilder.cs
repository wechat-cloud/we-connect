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
            _apiDescription.Resource = resource;
            return this;
        }

        public ApiDescriptionBuilder UseHttp()
        {
            _apiDescription.UseHttpProtocal();
            return this;
        }

        public ApiDescriptionBuilder UseHttps()
        {
            _apiDescription.UseHttpsProtocal();
            return this;
        }

        public ApiDescriptionBuilder UseGet() {
            return UseMethod(HttpMethod.Get);
        }

        public ApiDescriptionBuilder UsePost()
        {
            return UseMethod(HttpMethod.Post);
        }

        public ApiDescriptionBuilder UseMethod(HttpMethod method)
        {
            _apiDescription.Method = method;
            return this;
        }

        public ApiDescriptionBuilder Form(string pKey, string pValue)
        {
            _apiDescription.FormKeyValues.Add(pKey, pValue);
            return this;
        }

        public ApiDescriptionBuilder Json<T>(T target)
        {
            _apiDescription.SetJsonBody(target);
            return this;
        }

        public ApiDescriptionBuilder UseParameter(string pKey, string pValue)
        {
            _apiDescription.QueryParameters.Add(pKey, pValue);
            return this;
        }

        public ApiDescriptionBuilder AddFile(string key, FileDescription fileDescription)
        {
            _apiDescription.Files.Add(key, fileDescription);
            return this;
        }
    }
}
