using CloudFlare.Client.Client.Zones;

namespace CloudFlare.Client.Client.Zones
{
    /// <summary>
    /// Interface for <see cref="Workers"/>
    /// </summary>
    public interface IWorkers
    {
        /// <summary>
        /// Interface for <see cref="Routes"/>
        /// </summary>
        /// <value>The implementation of worker route interaction</value>
        IRoutes Routes { get; }
    }
}
