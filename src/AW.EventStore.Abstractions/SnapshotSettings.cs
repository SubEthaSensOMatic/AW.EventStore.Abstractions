namespace AW.EventStore;

public static class SnapshotSettings
{
    public static int SnapshotAfterNthVersion { get; set; } = 100;
}
