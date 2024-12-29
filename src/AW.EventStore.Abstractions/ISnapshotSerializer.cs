namespace AW.EventStore;

public interface ISnapshotSerializer
{
    (string SnapshotType, byte[] Snapshot) Serialize(object snapshot);

    object? Deserialize(string snapshotType, byte[] snapshot);
}
