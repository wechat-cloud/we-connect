using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WeConnect.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace WeConnect
{
    internal class DefaultJsonSerializer : IJsonSerializer
    {
        public string Serialize<T>(T target)
        {
            var setting = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            return JsonConvert.SerializeObject(target, setting);
        }

        public T Deserialize<T>(string source)
        {
            return JsonConvert.DeserializeObject<T>(source);
        }

        public dynamic Deserialize(string source) {
            dynamic result = JsonConvert.DeserializeObject(source);
            return result;
        }
    }
}
