namespace DeliveryServiceProject.TypeOfOrders;

public class VIPOrder : Order
{
    private string _gift;
    public string Gift
    {
        get
        {
            return _gift;
        }
        set
        {
            if (value.ToLower() == "nothing")
            {
                throw new ArgumentException("Fix problem in VIPorder. We need to give him something.");
            }
            _gift = value;
        }
    }
    public VIPOrder(string name, long phoneNumber, float price, string deliveryAdress, string gift) : base(name, phoneNumber, price, deliveryAdress)
    {
        Gift = gift;
    }
    public override string GetFullInfo()
    {
        return $"Product name: {Name}\nPhone number: {PhoneNumber}\nPrice: {Price}$\nDelivery address: {DeliveryAddress}\nGift :{Gift}\n\n";
    }
}
