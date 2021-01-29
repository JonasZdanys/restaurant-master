using System;
using System.Threading;

namespace Restaurant
{
    public class Pizza
    {
        private readonly string[] _toppings;

        public string Name { get; }

        public Pizza(string name, string[] toppings)
        {
            Name = name;
            _toppings = toppings;
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
            foreach (var topping in _toppings)
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
