using System.Threading.Channels;

namespace OpenSleigh.Transport.InMemory
{
    public static class ChannelReaderExtensions
    {
        public static async Task<IEnumerable<T>> ReadMultipleAsync<T>(this ChannelReader<T> reader, int maxBatchSize, CancellationToken cancellationToken)
        {
            await reader.WaitToReadAsync(cancellationToken);

            var batch = new List<T>(maxBatchSize);

            while (batch.Count < maxBatchSize && reader.TryRead(out T message) && message is not null)
            {
                batch.Add(message);
            }

            return batch;
        }
    }
}