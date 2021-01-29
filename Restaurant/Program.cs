using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main()
        {
            List<Pizza> OrderQueue = GetOrders();
            foreach (var item in OrderQueue)
            {
                item.Prepare();
            }
            List<Soup> warmup = Appitizers();
            foreach (var soup in warmup)
            {
                soup.HeatThePot();
            }
        }

        private static List<Pizza> GetOrders()
        {
            var orders = new List<Pizza>()
            {
                new Pizza("Margherita", new string[] { "tomatoes", "basil", "mozzarella" }),
                new Pizza("Pepperoni", new string[] { "pepperoni", "mozzarella" }),
            };
            return orders;
        }
        private static List<Soup> Appitizers ()
        {
            var soups = new List<Soup>()
            {
                new Soup("My Favourite", new string[] { "chicken", "onion", "potatoes", "carrots", "egg-plant","paprika", "coriander", "celery"}, new string [] {"cumin", "salt", "pepper"})
            };
            return soups;
        }
    }
}
