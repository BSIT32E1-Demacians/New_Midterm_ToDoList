using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class ToDo
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Category { get; set; } 

        public bool Done { get; set; } = false;
    }
}
