using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zones
{
    /// <summary>
    /// Browser Cache TTL Settings
    /// </summary>
    public class BrowserCacheTTLSetting
    {
        /// <summary>
        /// Id for Browser Cache TTL Setting
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Value of Browser Cache TTL. default value: 14400. Valid values: 0, 30, 60, 120, 300, 1200,
        /// 1800, 3600, 7200, 10800, 14400, 18000, 28800, 43200, 57600, 72000, 86400, 172800, 259200,
        /// 345600, 432000, 691200, 1382400, 2073600, 2678400, 5356800, 16070400, 31536000
        /// </summary>
        /// <remarks>Setting a TTL of 0 is equivalent to selecting `Respect Existing Headers`</remarks>
        [JsonProperty("value")]
        public int Value { get; set; }

        /// <summary>
        /// Determines if UI allows for editing
        /// </summary>
        [JsonProperty("editable")]
        public bool Editable { get; set; }

        /// <summary>
        /// Date of last modification
        /// </summary>
        [JsonProperty("modified_on")]
        public DateTime? ModifiedOn { get; set; }
    }
}
