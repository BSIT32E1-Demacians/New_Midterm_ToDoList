using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
namespace Midterm_ToDoList.Models
{
    public class NToDo
    {
        [Key]
        
        public int Id { get; set; }

       [Required]
       
       
        public string Description { get; set; }

        public string Category { get; set; }

        public bool Done { get; set; } = false;

    }
}
