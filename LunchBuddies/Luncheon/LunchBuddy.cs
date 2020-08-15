using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies.Luncheon
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Food { get; set; }
        public LunchBuddy(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        public void Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} { LastName} is at {restaurant.Name} eating good.");
        }
        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office .");
        }
        public void Eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            foreach (var companion in companions)
            {
                Console.WriteLine($"{FirstName} { LastName} is at {restaurant.Name} eating good with {companion.FirstName}.");
            }

        }
        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Food = food;

            foreach (var companion in companions)
            {
                Console.WriteLine($"{FirstName} { LastName} is at {restaurant.Name} eating good with {companion.FirstName}. {companion.FirstName} ordered the {Food}.");
            }
        }
    }
}
