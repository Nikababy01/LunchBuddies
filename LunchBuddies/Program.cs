using LunchBuddies.Luncheon;
using System;


namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kay = new LunchBuddy("Kay", "Thomas");
            Kay.Eat();
            Kay.Eat("Hot Chicken");
        }
    }
}
