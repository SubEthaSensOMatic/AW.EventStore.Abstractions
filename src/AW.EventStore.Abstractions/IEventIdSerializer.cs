namespace AW.EventStore;

public interface IEventIdSerializer
{
    byte[] Serialize(IEventId eventId);

    IEventId? Deserialize(byte[] eventId);
}
