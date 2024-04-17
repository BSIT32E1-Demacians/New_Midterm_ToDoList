using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDo.Domain
{
    public class ToDoService : IToDoService
    {
        private readonly IToDoRepository _toDoRepository;

        public ToDoService(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public async Task<List<ToDo>> GetAllAsync()
        {
            return await _toDoRepository.GetAllAsync();
        }

        public async Task<ToDo> GetByIdAsync(int id)
        {
            return await _toDoRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(ToDo toDo)
        {
            await _toDoRepository.AddAsync(toDo);
        }

        public async Task UpdateAsync(ToDo toDo)
        {
            await _toDoRepository.UpdateAsync(toDo);
        }

        public async Task DeleteAsync(int id)
        {
            await _toDoRepository.DeleteAsync(id);
        }
    }
}