using DeliveryServiceProject.TypeOfOrders;
using DeliveryServiceProject.Interfaces;
namespace DeliveryServiceProject
{
    public class DeliveryService
    {
        const byte MAX_TIME_ORDER_IS = 255;
        public List<Order> _orders = new List<Order>();
        public List<IDelivery> _deliveries = new List<IDelivery>();
        public List<Order> toDelivery = new List<Order>();        
        public string Name { get; }
        public DeliveryService(string name) 
        {
            Name = name;
        }
        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }
        public void RemoveOrder(Order order)
        {
            _orders.Remove(order);
        }
        public void AddDelivery(IDelivery delivery)
        {
            _deliveries.Add(delivery);
        }
        public void RemoveDelivery(IDelivery delivery)
        {
            _deliveries.Remove(delivery);
        }
        /// <summary>
        /// All delivery providers on the list are asked for delivery times. The delivery provider who offers the best option is selected.
        /// </summary>
        /// <param name="orderName">The name of the product we want to send.</param>
        public void MakeDelivery(String orderName)
        {   
           foreach (Order order in _orders)
            {
                if (order.Name == orderName)
                {
                    toDelivery.Add(order);
                    _orders.Remove(order);
                    break;
                }
            }
            int minTime = MAX_TIME_ORDER_IS;
            foreach (Order order in toDelivery)
            {
                foreach (IDelivery delivery in _deliveries)
                {                   
                    if (delivery.ExpectedDeliveryTime() < minTime)
                    {
                        minTime = delivery.ExpectedDeliveryTime();
                    }
                }
            }
            foreach (IDelivery delivery in _deliveries)
            {
                if (delivery.ExpectedDeliveryTime() == minTime)
                {
                    delivery.DeliveryOrder(toDelivery.Where(x => x.Name == orderName).FirstOrDefault());
                    _deliveries.Remove(delivery);                    
                    break;
                }
            }
        }
    }
}
