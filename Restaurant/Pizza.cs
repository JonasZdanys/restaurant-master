using System;
using System.Threading;

namespace Restaurant
{
    public class Pizza : IDish
    {
        private readonly string[] _ingredients;

        public string Name { get; }

        public Pizza(string name, string[] toppings)
        {
            Name = name;
            _ingredients = toppings;
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name} pizza.");
            PrepareDough();
            AddToppings();
            Bake();
            Console.WriteLine("Pizza ready!!\n");
        }

        private void PrepareDough()
        {
            Console.WriteLine($"Preparing dough..");
            Thread.Sleep(1000);
        }

        private void AddToppings()
        {
            foreach (var topping in _ingredients)
            {
                Console.WriteLine($"Adding {topping}..");
                Thread.Sleep(500);
            }
        }

        private void Bake()
        {
            Console.WriteLine($"Baking pizza..");
            Thread.Sleep(1000);
        }
    }
}
