using DotNetCore.Application.Common.Mappings;
using DotNetCore.Domain.Entities;

namespace DotNetCore.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
