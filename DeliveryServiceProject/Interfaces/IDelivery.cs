using DeliveryServiceProject.TypeOfOrders;
namespace DeliveryServiceProject.Interfaces
{
    public interface IDelivery
    {
        public void DeliveryOrder(Order order);
        public int ExpectedDeliveryTime();
    }
}
