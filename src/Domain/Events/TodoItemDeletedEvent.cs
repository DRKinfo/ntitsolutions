namespace ntitsolutions.Domain.Events;

public class TodoItemDeletedEvent : BaseEvent
{
    public TodoItemDeletedEvent(Plano item)
    {
        Item = item;
    }

    public Plano Item { get; }
}
