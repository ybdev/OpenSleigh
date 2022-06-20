using System.Runtime.CompilerServices;
using System.Threading.Channels;
using OpenSleigh.Core.Messaging;

[assembly: InternalsVisibleTo("OpenSleigh.Persistence.InMemory.Tests")]
namespace OpenSleigh.Transport.InMemory
{
    public interface IChannelFactory
    {
        ChannelWriter<TM> GetWriter<TM>() where TM : IMessage;
    }
}