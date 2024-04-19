using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Repository
{
    public class ToDoRepository
    {
        private readonly List<ToDo> _todos = new List<ToDo>();
        private int _nextId = 1;

        public ToDo Create(ToDo todo)
        {
            todo.Id = _nextId++;
            _todos.Add(todo);
            return todo;
        }

        public ToDo GetById(int id)
        {
            return _todos.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<ToDo> GetAll()
        {
            return _todos.ToList();
        }

        public void Update(ToDo updatedTodo)
        {
            var existingTodo = GetById(updatedTodo.Id);
            if (existingTodo != null)
            {
                existingTodo.Description = updatedTodo.Description;
                existingTodo.Category = updatedTodo.Category;
                existingTodo.Done = updatedTodo.Done;
            }
        }

        public void Delete(int id)
        {
            var todoToRemove = GetById(id);
            if (todoToRemove != null)
            {
                _todos.Remove(todoToRemove);
            }
        }
    }
}