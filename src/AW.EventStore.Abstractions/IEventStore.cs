using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AW.EventStore;

public record Snapshot(object State, int StreamVersion);

public interface IEventStore
{
    Task CreateStream(
        string streamId, string streamType,
        IEnumerable<object> eventPayloads,
        string? user = null, string? correlationId = null, string? causationId = null);

    Task AppendToStream(
        string streamId, int expectedStreamVersion,
        IEnumerable<object> eventPayloads,
        string? user = null, string? correlationId = null, string? causationId = null);

    Task<IEnumerable<Event>> LoadStream(string streamId, CancellationToken cancel, int startVersion = 0);

    Task<IEnumerable<Event>> StreamEvents(IEventId? lastEventId, long maxCount, CancellationToken cancel);

    Task CreateSnapshot(string streamId, int streamVersion, object state);

    Task<Snapshot?> LoadSnapshot(string streamId);
}
