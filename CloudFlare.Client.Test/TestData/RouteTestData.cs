using System;
using System.Collections.Generic;
using System.Text;
using CloudFlare.Client.Api.Zones.Workers;

namespace CloudFlare.Client.Test.TestData
{
    public static class RouteTestData
    {
        public static List<Route> Routes { get; set; } = new()
        {
            new Route
            {
                Id = Guid.NewGuid().ToString(),
                Pattern = "*.testdomain.com/*",
                Script = Guid.NewGuid().ToString()
            },
            new Route
            {
                Id = Guid.NewGuid().ToString(),
                Pattern = "*.testdomain2.com/*",
                Script = Guid.NewGuid().ToString()
            }
        };
    }
}
