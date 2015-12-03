using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeConnect.Core
{
    public interface IJsonSerializer
    {
        string Serialize<T>(T target);
        T Deserialize<T>(string source);
    }
}
