namespace DeliveryServiceProject.TypeOfOrders;

public class OrdinaryOrder : Order
{
    public OrdinaryOrder(string name, long phoneNumber, float price, string deliveryAdress) : base(name, phoneNumber, price, deliveryAdress)
    {

    }
    public override string GetFullInfo()
    {
        return $"Product name: {Name}\nPhone number: {PhoneNumber}\nPrice: {Price}$\nDelivery address: {DeliveryAddress}\n\n";
    }
}
