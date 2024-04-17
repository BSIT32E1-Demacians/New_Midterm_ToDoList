using System.ComponentModel;
using ToDo.Domain.Interface;
using ToDo.Repositories;
namespace ToDo.Repositories
{
    public class staticRepository : ITodoRepository
    {
        
        public Domain.ToDo Add(Domain.ToDo toDo)
        {
            if(toDo == null)
            {
                throw new ArgumentNullException(nameof(toDo));
            }

            
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.ToDo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Domain.ToDo> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Domain.ToDo Update(Domain.ToDo toDo)
        {
            throw new NotImplementedException();
        }
    }
}
