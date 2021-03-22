using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class TodoItem
    {
        [Required(ErrorMessage = "Please type in the task")]
        public string TaskName { get; set; }

        public bool IsComplete { get; set; }
    }
}
