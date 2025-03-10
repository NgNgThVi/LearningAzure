using MediatR;

namespace ViNNT.Template.Presentation.Domain.Common;

public abstract class BaseEvent : INotification
{
    public Guid Id { get; set; }
}