using ntitsolutions.Application.TodoLists.Queries.ExportTodos;

namespace ntitsolutions.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
