namespace DeliveryServiceProject.TypeOfOrders;

public class DiscountOrder : Order
{
    /// <summary>
    /// 0.01 = 1%
    /// </summary>
    const float MAX_DISCOUNT_IN_PROCENT = 0.50F;
    private float _discount;
    public float Discount
    {
        get
        {
            return _discount;
        }
        set
        {
            if (value > Price * MAX_DISCOUNT_IN_PROCENT)
            {
                throw new ArgumentException($"Fix problem in DiscountOrder! The discount cannot be more than {MAX_DISCOUNT_IN_PROCENT * 100}% of the cost of the product");
            }
            _discount = value;
        }
    }
    public DiscountOrder(string name, long phoneNumber, float price, string deliveryAdress, float discount) : base(name, phoneNumber, price, deliveryAdress)
    {
        Discount = discount;
    }
    public override string GetFullInfo()
    {
        return $"Product name: {Name}\nPhone number: {PhoneNumber}\nPrice: {Price}$\nDelivery address: {DeliveryAddress}\nDiscount: {Discount}\n\n";
    }
}
