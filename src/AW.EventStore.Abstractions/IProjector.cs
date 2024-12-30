using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AW.EventStore;

public interface IProjector
{
    Task Project(IReadOnlyList<Event> events, CancellationToken cancel);

    Task Purge(CancellationToken cancel);
}
