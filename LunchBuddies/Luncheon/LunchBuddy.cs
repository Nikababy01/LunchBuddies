﻿using System;
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
            var firstnames = new List<string> { };
            foreach (var companion in companions)
            {
               var names = companion.FirstName;
                firstnames.Add(names);
            }
                string friends = string.Join(" and ", firstnames);
                Console.WriteLine($"{FirstName} { LastName} is at {restaurant.Name} eating good with {friends}.");

        }
        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Food = food;
            var firstnames = new List<string> { };
            foreach (var companion in companions)
            {
                var names = companion.FirstName;
                firstnames.Add(names);
            }
            string friends = string.Join(" and ", firstnames);
            Console.WriteLine($"{FirstName} { LastName} is at {restaurant.Name} eating good with {friends}. {friends} ordered the {Food}.");
        }
    }
}
