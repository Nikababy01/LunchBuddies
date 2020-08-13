using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies.Luncheon
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LunchBuddy(string firstname, string lastname )
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
        
    }
}
