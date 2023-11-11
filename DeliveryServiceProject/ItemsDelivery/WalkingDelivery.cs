using DeliveryServiceProject.TypeOfOrders;
using DeliveryServiceProject.Interfaces;

namespace DeliveryServiceProject.ItemsDelivery
{
    public class WalkingDelivery : IDelivery
    {
        string Name { get; }
        int Time { get; }
        public WalkingDelivery(string name)
        {
            Name = name;
            Time = 200;
        }
        public void DeliveryOrder(Order order)
        {
            Console.WriteLine($"Walkin delivery {Name} begin delivery {order.Name} to {order.DeliveryAddress}! Delivery time is {Time} min.");
        }
        public int ExpectedDeliveryTime()
        {
            return Time;
        }
    }
}
