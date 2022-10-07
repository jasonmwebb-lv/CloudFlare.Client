using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones.Workers
{
    /// <summary>
    /// A Route Trigger related to a worker service.
    /// </summary>
    public class Route
    {
        /// <summary>
        /// The domain name
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The domain name
        /// </summary>
        [JsonProperty("pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// The domain name
        /// </summary>
        [JsonProperty("script")]
        public string Script { get; set; }
    }
}
