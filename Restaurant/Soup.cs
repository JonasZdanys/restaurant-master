using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Restaurant
{
    public class Soup : IDish
    {
        private readonly string[] _ingredients;
        private readonly string[] _spices;
        public string Name { get; }

        public Soup(string name, string[] ingredients, string [] seasoning)
        {
            Name = name;
            _ingredients = ingredients;
            _spices = seasoning;
        }
        public void Prepare()
        {
            Console.WriteLine($"Making {Name} soup.");
            BoilingWater();
            ChoppingIngredients();
            AddingIngredients();
            AddSeasoning();
            WaitUntilItIsDone();
            Console.WriteLine("Enjoy!!\n");
        }
        private void BoilingWater()
        {
            Console.WriteLine($"Boiling Water..");
            Thread.Sleep(500);
            Console.WriteLine($"Caution! HOT!!!");
            Thread.Sleep(1000);
        }
        private void ChoppingIngredients()
        {
            foreach (var ingredient in _ingredients)
            {
                Console.WriteLine($"Chopping {ingredient}..");
                Thread.Sleep(500);
            }
        }
        private void AddingIngredients()
        {
            foreach (var ingredient in _ingredients)
            {
                Console.WriteLine($"Adding {ingredient} to the soup..");
                Thread.Sleep(500);
            }
        }
        private void AddSeasoning()
        {
            foreach (string spice in _spices)
            {
                Console.WriteLine($"Add a dash of {spice}..");
                Thread.Sleep(500);
            }
        }
        private void WaitUntilItIsDone()
        {
            Console.WriteLine($"Let it simmer..");
            Thread.Sleep(1000);
        }
    }
}
