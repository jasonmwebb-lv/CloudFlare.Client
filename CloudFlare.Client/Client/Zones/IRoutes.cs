using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CloudFlare.Client.Api.Result;
using CloudFlare.Client.Api.Zones.Workers;

namespace CloudFlare.Client.Client.Zones
{
    /// <summary>
    /// Interface for interacting with routes
    /// </summary>
    public interface IRoutes
    {
        /// <summary>
        /// Adds a route to the worker service
        /// </summary>
        /// <param name="zoneId">Zone Identifier</param>
        /// <param name="route">Route</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Id of newly generated <see cref="Route"/></returns>
        Task<CloudFlareResult<string>> AddRouteAsync(string zoneId, Route route, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of routes for the worker services
        /// </summary>
        /// <param name="zoneId">Zone Identifier</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>List of routes</returns>
        Task<CloudFlareResult<IReadOnlyList<Route>>> GetAsync(string zoneId, CancellationToken cancellationToken = default);
    }
}
