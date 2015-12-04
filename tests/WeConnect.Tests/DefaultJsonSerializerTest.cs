using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace WeConnect.Tests
{
    public class DefaultJsonSerializerTest
    {
        private readonly DefaultJsonSerializer _serializer;
        public DefaultJsonSerializerTest()
        {
            _serializer = new DefaultJsonSerializer();
        }

        [Fact]
        public void TestSerialize() {
            var obj = new { First = "hello", Second = 12 };
            var json = _serializer.Serialize(obj);
            Assert.NotNull(json);
        }

        [Fact]
        public void TestDeserializeCorrection()
        {
            var obj = new TestClass { P1 = 10, P2 = "p2" };
            var json = _serializer.Serialize(obj);
            var newObj = _serializer.Deserialize<TestClass>(json);

            Assert.Equal(obj.P1, newObj.P1);
            Assert.Equal(obj.P2, newObj.P2);
        }

        [Fact]
        public void TestDeserializeDynamicCorrection() {
            var obj = new { A = "string", B = 12, C = true };
            var json = _serializer.Serialize(obj);
            var newObj = _serializer.Deserialize(json);
            
            Assert.Equal(obj.A, (string)newObj.a);
            Assert.Equal(obj.B, (int)newObj.b);
            Assert.Equal(obj.C, (bool)newObj.c);
        }

        private class TestClass {
            public int P1 { get; set; }
            public string P2 { get; set; }
        }
    }
}
