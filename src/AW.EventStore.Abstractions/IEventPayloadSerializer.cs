namespace AW.EventStore;

public interface IEventPayloadSerializer
{
    (string EventType, byte[] Payload) Serialize(object payload);

    object? Deserialize(string eventType, byte[] payload);
}
