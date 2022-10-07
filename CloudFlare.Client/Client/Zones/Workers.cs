using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CloudFlare.Client.Api.Parameters.Endpoints;
using CloudFlare.Client.Api.Result;
using CloudFlare.Client.Api.Zones;
using CloudFlare.Client.Client.Zones;
using CloudFlare.Client.Contexts;
using CloudFlare.Client.Enumerators;

namespace CloudFlare.Client.Client.Zones
{
    /// <inheritdoc />
    public class Workers : ApiContextBase<IConnection>, IWorkers
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Workers"/> class
        /// </summary>
        /// <param name="connection">Connection settings</param>
        public Workers(IConnection connection)
            : base(connection)
        {
            Routes = new Routes(connection);
        }

        /// <inheritdoc />
        public IRoutes Routes { get; }
    }
}
