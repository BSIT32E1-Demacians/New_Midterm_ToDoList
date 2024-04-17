
using System.ComponentModel.DataAnnotations;

namespace ToDo.Domain
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a due date.")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public string CategoryId { get; set; } = string.Empty;

        public Category Category { get; set; } = null!;

        [Required(ErrorMessage = "Please select a status.")]

        public string Status { get; set; } = string.Empty;

        public bool Done { get; set; } = false;
    }
}
