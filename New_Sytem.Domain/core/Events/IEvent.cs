using MediatR;

namespace New_Sytem.Domain.core.Events;

public interface IEvent : INotification
{
    Guid EventId { get;  }

    DateTime OccuredOn { get; }
}
