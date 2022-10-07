using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudFlare.Client.Api.Parameters.Endpoints;
using CloudFlare.Client.Contexts;
using CloudFlare.Client.Test.Helpers;
using CloudFlare.Client.Test.TestData;
using FluentAssertions;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using WireMock.Server;
using Xunit;

namespace CloudFlare.Client.Test.Zones
{
    public class RoutesUnitTests
    {
        private readonly WireMockServer _wireMockServer;
        private readonly ConnectionInfo _connectionInfo;

        public RoutesUnitTests()
        {
            _wireMockServer = WireMockServer.Start();
            _connectionInfo = new WireMockConnection(_wireMockServer.Urls.First()).ConnectionInfo;
        }

        [Fact]
        public async Task TestAddRouteAsync()
        {
            var zone = ZoneTestData.Zones.First();
            var route = RouteTestData.Routes.First();

            _wireMockServer
                .Given(Request.Create().WithPath($"/{ZoneEndpoints.Base}/{zone.Id}/{WorkerEndpoints.Routes}").UsingPost())
                .RespondWith(Response.Create().WithStatusCode(200)
                    .WithBody(WireMockResponseHelper.CreateTestResponse(route.Id)));

            using var client = new CloudFlareClient(WireMockConnection.ApiKeyAuthentication, _connectionInfo);

            var idUnderTest = await client.Zones.Workers.Routes.AddRouteAsync(zone.Id, route);

            idUnderTest.Result.Should().BeEquivalentTo(route.Id);
        }

        [Fact]
        public async Task TestGetAsync()
        {
            var zone = ZoneTestData.Zones.First();
            var routes = RouteTestData.Routes;

            _wireMockServer
                .Given(Request.Create().WithPath($"/{ZoneEndpoints.Base}/{zone.Id}/{WorkerEndpoints.Routes}").UsingGet())
                .RespondWith(Response.Create().WithStatusCode(200)
                    .WithBody(WireMockResponseHelper.CreateTestResponse(routes)));

            using var client = new CloudFlareClient(WireMockConnection.ApiKeyAuthentication, _connectionInfo);

            var routesUnderTest = await client.Zones.Workers.Routes.GetAsync(zone.Id);

            routesUnderTest.Result.Should().BeEquivalentTo(routes);
        }
    }
}
