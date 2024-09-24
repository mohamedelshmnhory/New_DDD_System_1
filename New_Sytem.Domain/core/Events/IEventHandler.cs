using MediatR;

namespace New_Sytem.Domain.core.Events;

public interface IEventHandler<in TDomainEvent> : INotificationHandler<TDomainEvent>
    where TDomainEvent : IEvent
{

}
