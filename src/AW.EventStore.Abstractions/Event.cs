using System;

namespace AW.EventStore;

public record struct Event(
    IEventId EventId, string EventType, DateTimeOffset EventCreatedAt, string? EventCreatedBy, object EventPayload,
    string StreamId, string StreamType, int StreamVersion,
    string? CorrelationId, string? CausationId);

