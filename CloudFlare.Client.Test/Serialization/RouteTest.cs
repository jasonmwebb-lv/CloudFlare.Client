using System;
using System.Collections.Generic;
using System.Text;
using CloudFlare.Client.Api.Zones.Workers;
using CloudFlare.Client.Test.Helpers;
using FluentAssertions;
using Xunit;

namespace CloudFlare.Client.Test.Serialization
{
    public class RouteTest
    {
        [Fact]
        public void TestSerialization()
        {
            var sut = new Route();

            JsonHelper.GetSerializedKeys(sut).Should().BeEquivalentTo(new SortedSet<string> { "id", "pattern", "script" });
        }
    }
}
