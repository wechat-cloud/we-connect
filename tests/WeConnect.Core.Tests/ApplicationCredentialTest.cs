using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeConnect.Core;
using Xunit;

namespace WeConnect.Core.Tests
{
    public class ApplicationCredentialTest
    {
        [Fact]
        public void ConstructorNullParametersTest() {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var ac = new ApplicationCredential(null, null);
            });
        }

        [Fact]
        public void ConstructorEmptyStringParametersTest() {
            Assert.Throws<ArgumentNullException>(() => {
                var ac = new ApplicationCredential("", "");
            });
        }

        [Fact]
        public void EqualityTest() {
            var appId = Guid.NewGuid().ToString();
            var appSecret = Guid.NewGuid().ToString();

            var ac1 = new ApplicationCredential(appId, appSecret);
            var ac2 = new ApplicationCredential(appId, appSecret);

            Assert.Equal(ac1, ac2);
            Assert.Equal(ac1.GetHashCode(), ac2.GetHashCode());
        }

        [Fact]
        public void FriendlyInformationTest() {
            var ac = new ApplicationCredential("appId", "appSecret");
            var expected = "appId: appId, appSecret: appSecret";

            Assert.Equal(expected, ac.ToString());
        }
    }
}
