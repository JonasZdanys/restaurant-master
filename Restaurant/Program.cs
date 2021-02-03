using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main()
        {
            List<IDish> OrderQueue = GetOrders();
            foreach (var item in OrderQueue)
            {
                item.Prepare();
            }
        }

        private static List<IDish> GetOrders()
        {
            var orders = new List<IDish>()
            {
                new Pizza("Margherita", new string[] { "tomatoes", "basil", "mozzarella" }),
                new Pizza("Pepperoni", new string[] { "pepperoni", "mozzarella" }),
                new Soup("My Favourite", new string[] { "chicken", "onion", "potatoes", "carrots", "egg-plant","paprika", "coriander", "celery"}, new string [] {"cumin", "salt", "pepper"})
            };
            return orders;
        }
    }
}
