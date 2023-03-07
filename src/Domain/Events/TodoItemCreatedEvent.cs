namespace ntitsolutions.Domain.Events;

public class TodoItemCreatedEvent : BaseEvent
{
    public TodoItemCreatedEvent(Plano item)
    {
        Item = item;
    }

    public Plano Item { get; }
}
