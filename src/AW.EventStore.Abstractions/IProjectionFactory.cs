using System.Threading;
using System.Threading.Tasks;

namespace AW.EventStore;

public enum ProjectionStates
{
    Starting, FetchingEvents, WaitingForEvents, ProjectingEvents, SavingCheckpoint, ProjectionError, Terminated
}

public delegate void ProjectionStateChangedCallback(ProjectionStates state);

public interface IProjectionFactory
{
    Task BeginProjection(
        string identifier, IProjector projector, CancellationToken cancel, 
        int batchSize = 10000, IProjectionCheckpointStorage? storage = null, 
        ProjectionStateChangedCallback? callback = null);
}
