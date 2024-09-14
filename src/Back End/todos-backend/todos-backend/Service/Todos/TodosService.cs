using todos_backend.Data;
using todos_backend.Models;

namespace todos_backend.Service.Todos
{
    public class TodosService : ITodosService
    {

        private readonly TodosDbContext _dbContext;

        public TodosService(TodosDbContext dbContext) {
            _dbContext = dbContext;
        }

        public bool AddTodos(Todo todo)
        {
            _dbContext.Todos.Add(todo);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DelTodos(int todo)
        {
            Todo _todo = _dbContext.Todos.Find(todo);
            _dbContext.Todos.Remove(_todo);
            _dbContext.SaveChanges();
            return true;

        }

        public List<Todo> GetTodos()
        {
            return _dbContext.Todos.OrderByDescending(x=>x.Id).ToList();
        }

        public bool UpdateTodos(int todo)
        {
            throw new NotImplementedException();
        }
    }
}
