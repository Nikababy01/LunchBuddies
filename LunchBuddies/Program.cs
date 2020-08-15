using LunchBuddies.Luncheon;
using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var kay = new LunchBuddy("Kay", "Thomas");
            kay.Eat();
            kay.Eat("Hot Chicken");
            
            var marie = new LunchBuddy("Marie", "Thomas");
            var earl = new LunchBuddy("Earl", "Thomas");
            
            var companions = new List<LunchBuddy> { };
            companions.Add(marie);
            companions.Add(earl);
            
            kay.Eat(companions);
            kay.Eat("Spaghetti", companions);
        }
    }
}
