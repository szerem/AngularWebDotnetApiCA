using AngularWebDotnetApiCA.Application.TodoLists.Queries.ExportTodos;

namespace AngularWebDotnetApiCA.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
