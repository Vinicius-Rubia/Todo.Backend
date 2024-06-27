using Todo.Domain.Entities;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]
    public class TodoItemTests
    {
        private readonly TodoItem _todo = new TodoItem("Título Aqui", "viniciusrubia", DateTime.Now);

        [TestMethod]
        public void Dado_novo_todo_o_mesmo_nao_pode_ser_concluido()
        {
            Assert.AreEqual(_todo.Done, false);
        }
    }
}
