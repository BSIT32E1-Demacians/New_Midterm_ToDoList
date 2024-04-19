using System;
using System.Collections.Generic;
using Domain;
using Repository;

namespace Service
{
    public class TodoService
    {
        private readonly ToDoRepository _repository;

        public TodoService(ToDoRepository repository)
        {
            _repository = repository;
        }

        public ToDo Create(ToDo todo)
        {
            if (string.IsNullOrWhiteSpace(todo.Description))
            {
                throw new ArgumentException("Description cannot be empty");
            }
            return _repository.Create(todo);
        }

        public ToDo GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<ToDo> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(ToDo updatedTodo)
        {
            _repository.Update(updatedTodo);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}