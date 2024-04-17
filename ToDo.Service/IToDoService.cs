using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDo.Domain
{
    public interface IToDoService
    {
        Task<List<ToDo>> GetAllAsync();
        Task<ToDo> GetByIdAsync(int id);
        Task AddAsync(ToDo toDo);
        Task UpdateAsync(ToDo toDo);
        Task DeleteAsync(int id);
    }
}