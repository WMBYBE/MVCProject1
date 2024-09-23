namespace Project1.Models
{
    public class Greetings
    {
        public string? Name { get; set; } //Creates Name

        public string GenerateGreeting()
        {
            return $"Hello, {Name}! Welcome to the site!"; //Creates Greeting
        }
    }
}
