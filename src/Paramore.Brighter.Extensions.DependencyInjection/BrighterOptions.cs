using Microsoft.Extensions.DependencyInjection;
using Polly.Registry;

namespace Paramore.Brighter.Extensions.DependencyInjection
{
    public class BrighterOptions
    {
        /// <summary>
        ///     Configures the request context factory. Defaults to <see cref="InMemoryRequestContextFactory" />.
        /// </summary>
        public IAmARequestContextFactory RequestContextFactory { get; set; } = new InMemoryRequestContextFactory();

        /// <summary>
        ///     Configures the polly policy registry.
        /// </summary>
        public IPolicyRegistry<string> PolicyRegistry { get; set; } = new DefaultPolicy();

        /// <summary>
        ///     Configures task queues. 
        /// </summary>
        public MessagingConfiguration MessagingConfiguration { get; set; } = 

        /// <summary>
        ///     Configures how the services are injected. Defaults to Transient.
        /// </summary>
        public ServiceLifetime HandlerLifetime { get; set; } = ServiceLifetime.Transient;
    }
}