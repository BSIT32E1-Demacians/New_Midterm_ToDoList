using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Midterm_ToDoList.Models
{
    public class NToDo
    {

        public int Id { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public bool Done { get; set; } = false;

    }
}
