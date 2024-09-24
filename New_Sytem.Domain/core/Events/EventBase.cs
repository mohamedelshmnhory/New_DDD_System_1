namespace New_Sytem.Domain.core.Events;

public abstract record EventBase : IEvent
{
    public Guid EventId { get; }

    public DateTime OccuredOn { get; }

    protected EventBase()
    {
        EventId = Guid.NewGuid();
        OccuredOn = DateTime.UtcNow;
    }
}
