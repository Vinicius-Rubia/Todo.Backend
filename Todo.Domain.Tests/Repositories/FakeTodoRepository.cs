using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Tests.Repositories
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo)
        {

        }

        public TodoItem GetById(Guid Id, string user)
        {
            return new TodoItem("Titulo Aqui", "viniciusrubia", DateTime.Now);
        }

        public void Update(TodoItem todo)
        {

        }
    }
}
