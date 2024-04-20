using System;
using System.Collections.Generic;
using ToDo.Domain;
using ToDo.Repository;


namespace ToDo.Services
{
    public interface IToDoService
    {
        Domain.ToDo Create(Domain.ToDo todo);
        Domain.ToDo GetById(int id);
        IEnumerable<Domain.ToDo> GetAll();
        void Update(Domain.ToDo updatedTodo);
        void Delete(int id);
    }
}
