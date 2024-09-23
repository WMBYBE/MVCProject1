using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class Greetings
    {
        [Required(ErrorMessage = "Name is required.")] //Validation that data was entered
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")] //Validation of data
        public string? Name { get; set; } //Creates Name

        public string GenerateGreeting()
        {
            return $"Hello, {Name}! Welcome to the site!"; //Creates Greeting
        }
    }
}
