using New_Sytem.Domain.core.Events;

namespace New_Sytem.Domain.core.BaseType;

public abstract class AggregateRoot : Entity
{
    protected AggregateRoot(Guid id) : base(id) { }

    protected AggregateRoot() : base() { }

    private List<IEvent> domainEvent = [];

    public IReadOnlyCollection<IEvent> DomainEvent => domainEvent.AsReadOnly();

    public void AddEvent(IEvent @event) => domainEvent.Add(@event);

    public void Clear() => domainEvent.Clear();
    
}
