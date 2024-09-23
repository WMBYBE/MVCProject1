namespace Project1.Models
{
    public class Greetings
    {
        public string Name { get; set; }

        public string GenerateGreeting()
        {
            return $"Hello, {Name}! Welcome to the site!";
        }
    }
}
