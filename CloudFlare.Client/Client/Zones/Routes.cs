using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CloudFlare.Client.Api.Parameters.Endpoints;
using CloudFlare.Client.Api.Result;
using CloudFlare.Client.Api.Zones.Workers;
using CloudFlare.Client.Contexts;

namespace CloudFlare.Client.Client.Zones
{
    /// <inheritdoc />
    public class Routes : ApiContextBase<IConnection>, IRoutes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Routes"/> class
        /// </summary>
        /// <param name="connection">Connection settings</param>
        public Routes(IConnection connection)
            : base(connection)
        {
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<string>> AddRouteAsync(string zoneId, Route route, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{ZoneEndpoints.Base}/{zoneId}/{WorkerEndpoints.Routes}";
            return await Connection.PostAsync<string, Route>(requestUri, route, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<CloudFlareResult<IReadOnlyList<Route>>> GetAsync(string zoneId, CancellationToken cancellationToken = default)
        {
            var requestUri = $"{ZoneEndpoints.Base}/{zoneId}/{WorkerEndpoints.Routes}";
            return await Connection.GetAsync<IReadOnlyList<Route>>(requestUri, cancellationToken).ConfigureAwait(false);
        }
    }
}
