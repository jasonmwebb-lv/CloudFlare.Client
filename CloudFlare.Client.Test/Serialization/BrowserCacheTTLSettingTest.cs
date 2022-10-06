using System;
using System.Collections.Generic;
using System.Text;
using CloudFlare.Client.Api.Zones;
using CloudFlare.Client.Test.Helpers;
using FluentAssertions;
using Xunit;

namespace CloudFlare.Client.Test.Serialization
{
    public class BrowserCacheTTLSettingTest
    {
        [Fact]
        public void TestSerialization()
        {
            var sut = new BrowserCacheTTLSetting();

            JsonHelper.GetSerializedKeys(sut).Should().BeEquivalentTo(new SortedSet<string> { "id", "value", "editable", "modified_on" });
        }
    }
}
