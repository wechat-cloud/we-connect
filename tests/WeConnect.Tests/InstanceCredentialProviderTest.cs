using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace WeConnect.Tests
{
    public class InstanceCredentialProviderTest
    {
        [Fact]
        public void TestInvalidCase()
        {
            var provider = new InstanceCredentialProvider();

            Assert.Throws<ArgumentNullException>(() =>
            {
                var credential = provider.GenerateCredential();
            });
        }
    }
}
