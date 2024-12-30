using System.Threading.Tasks;

namespace AW.EventStore;

public interface IProjectionCheckpointStorage
{
    Task<bool> Exists();

    Task<IEventId?> Load();

    Task Save(IEventId? lastProcessedId);
}
