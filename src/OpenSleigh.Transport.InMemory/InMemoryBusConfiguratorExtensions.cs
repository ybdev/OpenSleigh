using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;
using OpenSleigh.Core.DependencyInjection;
using OpenSleigh.Core.Messaging;
using OpenSleigh.Transport.InMemory;

namespace OpenSleigh.Persistence.InMemory
{
    [ExcludeFromCodeCoverage]
    public static class InMemoryBusConfiguratorExtensions
    {
        public static IBusConfigurator UseInMemoryTransport(
            this IBusConfigurator busConfigurator)
        {
            busConfigurator.Services.AddSingleton<IPublisher, InMemoryPublisher>()
                .AddSingleton<IChannelFactory, ChannelFactory>();

            return busConfigurator;
        }
    }
}