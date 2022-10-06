using System.Threading;
using System.Threading.Tasks;
using CloudFlare.Client.Api.Result;
using CloudFlare.Client.Api.Zones;
using CloudFlare.Client.Enumerators;

namespace CloudFlare.Client.Client.Zones
{
    /// <summary>
    /// Interface for interacting with a Zone's SSL/TLS Edge Certificate Settings
    /// </summary>
    public interface IZoneSettings
    {
        /// <summary>
        /// Retrieves whether or not the SSL/TLS Edget Certificate requires HTTPS or not
        /// </summary>
        /// <param name="zoneId">Zone identifier</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Value of setting. "on" if required, "off" if not</returns>
        Task<CloudFlareResult<FeatureStatus>> GetAlwaysUseHttpsSettingAsync(string zoneId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates whether or not the SSL/TLS Edget Certificate requires HTTPS or not
        /// </summary>
        /// <param name="zoneId">Zone identifier</param>
        /// <param name="status">Enum for turning on/off requirement for always using SSL</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Value of setting. "on" if required, "off" if not</returns>
        Task<CloudFlareResult<FeatureStatus>> UpdateAlwaysUseHttpsSettingAsync(string zoneId, FeatureStatus status, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves Optimization/Minification settings for <see cref="Zone"/>
        /// </summary>
        /// <param name="zoneId">Zone identifier</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The minification setting</returns>
        Task<CloudFlareResult<MinifySetting>> GetMinifySettingAsync(string zoneId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates Optimization/Minification settings for <see cref="Zone"/>
        /// </summary>
        /// <param name="zoneId">Zone identifier</param>
        /// <param name="setting">Enum for turning on/off requirement for always using SSL</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The new minification setting</returns>
        Task<CloudFlareResult<MinifySetting>> UpdateMinifySettingAsync(string zoneId, MinifySetting setting, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="BrowserCacheTTLSetting"/> related to <see cref="Zone"/> within the Caching/Configuration
        /// </summary>
        /// <param name="zoneId">Zone identifier</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Browser Cache TTL settings</returns>
        Task<CloudFlareResult<BrowserCacheTTLSetting>> GetBrowserCacheTTLSettingAsync(string zoneId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sets the <see cref="BrowserCacheTTLSetting"/> related to the <see cref="Zone"/> within the Caching/Configuration
        /// </summary>
        /// <param name="zoneId">Zone identifier</param>
        /// <param name="value">Value of Browser Cache TTL. default value: 14400. Valid values: 0, 30, 60, 120, 300, 1200,
        /// 1800, 3600, 7200, 10800, 14400, 18000, 28800, 43200, 57600, 72000, 86400, 172800, 259200,
        /// 345600, 432000, 691200, 1382400, 2073600, 2678400, 5356800, 16070400, 31536000</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The new Browser Cache TTL settings</returns>
        /// <remarks>Setting a TTL of 0 is equivalent to selecting `Respect Existing Headers`</remarks>
        Task<CloudFlareResult<BrowserCacheTTLSetting>> UpdateBrowserCacheTTLSettingAsync(string zoneId, int value, CancellationToken cancellationToken = default);
    }
}
