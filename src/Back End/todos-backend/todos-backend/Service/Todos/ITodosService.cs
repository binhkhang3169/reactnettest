using todos_backend.Models;

namespace todos_backend.Service.Todos
{
    public interface ITodosService
    {
        List<Todo> GetTodos();
        Boolean AddTodos(Todo todo) ;
        Boolean UpdateTodos(int todo);
        Boolean DelTodos(int todo);
    }
}
