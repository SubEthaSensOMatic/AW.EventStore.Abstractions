using System;

namespace AW.EventStore;

public record StreamChangedNotification(string StreamId, int StreamVersion);

public interface IEventStoreNotifications
{
    event EventHandler StreamChanged;

    void Publish(StreamChangedNotification notification);
}
