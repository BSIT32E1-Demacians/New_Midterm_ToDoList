using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Repository
{
    public interface IToDoRepository
    {
        Domain.ToDo Create(Domain.ToDo todo);
        Domain.ToDo GetById(int id);
        IEnumerable<Domain.ToDo> GetAll();
        void Update(Domain.ToDo updatedTodo);
        void Delete(int id);
    }
}
