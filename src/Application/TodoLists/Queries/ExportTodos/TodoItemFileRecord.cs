using ntitsolutions.Application.Common.Mappings;
using ntitsolutions.Domain.Entities;

namespace ntitsolutions.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
