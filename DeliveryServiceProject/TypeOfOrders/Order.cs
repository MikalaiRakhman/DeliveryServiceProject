namespace DeliveryServiceProject.TypeOfOrders;

public abstract class Order : IComparable<Order>
{
    private string _name;
    private long _phoneNumber;
    private string _deliveryAdress;
    const byte SYMBOLS_PRODUCT_NAME_LIMIT = 20;
    const byte NUMS_PHONE_NUMBER_IS = 13;
    const float MIN_PRICE_VALUE = 0.01F;
    const float MAX_PRICE_VALUE = 1000F;
    const byte DELIVERY_ADRESS_CHARACTERS_MIN_VALUE = 3;
    const byte DELIVERY_ADRESS_CAHARACTERS_MAX_VALUE = 20;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (value.Length > SYMBOLS_PRODUCT_NAME_LIMIT)
            {
                throw new ArgumentException($"Product name is more than {SYMBOLS_PRODUCT_NAME_LIMIT} simblos!");
            }
            _name = value;
        }
    }
    public long PhoneNumber
    {
        get
        {
            return _phoneNumber;
        }
        set
        {
            if (value.ToString().Length != NUMS_PHONE_NUMBER_IS)
            {
                throw new ArgumentException($"The number must consist of {NUMS_PHONE_NUMBER_IS} digits!");
            }
            _phoneNumber = value;
        }
    }
    private float _price;
    public float Price
    {
        get
        {
            return _price;
        }
        set
        {
            if (value > MIN_PRICE_VALUE && value < MAX_PRICE_VALUE)
            {
                _price = value;
            }
            else
            {
                throw new ArgumentException($"Price must be greater than {MIN_PRICE_VALUE} and less than {MAX_PRICE_VALUE}");
            }
        }
    }
    public string DeliveryAddress
    {
        get
        {
            return _deliveryAdress;
        }
        set
        {
            if (value.Length < DELIVERY_ADRESS_CHARACTERS_MIN_VALUE || value.Length > DELIVERY_ADRESS_CAHARACTERS_MAX_VALUE)
            {
                throw new ArgumentException($"The delivery address must be a minimum of {DELIVERY_ADRESS_CHARACTERS_MIN_VALUE} characters and a maximum of {DELIVERY_ADRESS_CAHARACTERS_MAX_VALUE}");
            }
            _deliveryAdress = value;
        }
    }
    public Order(string name, long phoneNumber, float price, string deliveryAddress)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Price = price;
        DeliveryAddress = deliveryAddress;
    }
    public abstract string GetFullInfo();
    public int CompareTo(Order? other)
    {
        if (PhoneNumber < other.PhoneNumber)
            return -1;
        else if (PhoneNumber == other.PhoneNumber)
            return 0;
        return 1;
    }
}
