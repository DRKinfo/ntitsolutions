namespace ntitsolutions.Domain.Events;

public class TodoItemCompletedEvent : BaseEvent
{
    public TodoItemCompletedEvent(Plano item)
    {
        Item = item;
    }

    public Plano Item { get; }
}
