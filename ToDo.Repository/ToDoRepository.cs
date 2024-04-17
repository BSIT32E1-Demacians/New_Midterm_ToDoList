using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDo.Domain
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly AppDbContext _dbContext;

        public ToDoRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ToDo>> GetAllAsync()
        {
            return await _dbContext.ToDoSet.ToListAsync();
        }

        public async Task<ToDo> GetByIdAsync(int id)
        {
            return await _dbContext.ToDoSet.FindAsync(id);
        }

        public async Task AddAsync(ToDo toDo)
        {
            _dbContext.ToDoSet.Add(toDo);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(ToDo toDo)
        {
            _dbContext.Entry(toDo).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var toDo = await GetByIdAsync(id);
            if (toDo != null)
            {
                _dbContext.ToDoSet.Remove(toDo);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
