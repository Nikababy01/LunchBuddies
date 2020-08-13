using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies.Luncheon
{
    class Restaurant
    {
        // a private property that contains a List of restaurant names.
        private List<string> RestaurantNames = new List<string> { "Carabbas", "Coco Cafe", "Hattie B" };
        public string Name { get; set; }
        // constructor should pick a random restaurant name and assign it to a public property called "Name"
        public Restaurant()
        {
            var randomPick = new Random();
            Name = RestaurantNames[randomPick.Next(RestaurantNames.Count)];
        }

    }
}
