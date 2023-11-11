using DeliveryServiceProject.TypeOfOrders;
using DeliveryServiceProject;
using DeliveryServiceProject.ItemsDelivery;
namespace TestDeliveryServiceProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckValidNamePositive()
        {
            Order order = new OrdinaryOrder("Panasonic", 4857206823012, 25, "Minsk");
            Assert.AreEqual("Panasonic", order.Name);
        }
        [TestMethod]
        public void CheckValidNameNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new OrdinaryOrder("Panasonic is the Best", 4857206823012, 25, "Minsk"));
        }
        [TestMethod]
        public void CheckValidPhoneNumberPositive()
        {
            Order order = new OrdinaryOrder("Coca-Cola", 4857206823012, 20, "Kamennogorskaja 30");
            Assert.AreEqual(4857206823012, order.PhoneNumber);
        }
        [TestMethod]
        public void CheckValidPhoneNumberNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new OrdinaryOrder("Coca-Cola", 48572068230, 20, "Kamennogorskaja 30"));
        }
        [TestMethod]
        public void CheckValidPricePositive()
        {
            Order order = new OrdinaryOrder("Coca-Cola", 4857206823012, 20, "Kamennogorskaja 30");
            Assert.AreEqual(20, order.Price);
        }
        [TestMethod]
        public void CheckValidPriceNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new OrdinaryOrder("Coca-Cola", 4857206823012, 1500, "Kamennogorskaja 30"));
        }
        [TestMethod]
        public void CheckValidDeliveryAddressPositive()
        {
            Order order = new OrdinaryOrder("Panasonic", 4857206823012, 25, "Minsk");
            Assert.AreEqual("Minsk", order.DeliveryAddress);
        }
        [TestMethod]
        public void CheckValidDeliveryAddressNegative1() // less than 3 symbols
        {
            Assert.ThrowsException<ArgumentException>(() => new OrdinaryOrder("Panasonic", 4857206823012, 25, "NY"));
        }
        [TestMethod]
        public void CheckValidDeliveryAddressNegative2() // more than 20 symbols
        {
            Assert.ThrowsException<ArgumentException>(() => new OrdinaryOrder("Panasonic", 4857206823012, 25, "Minsk is the capital of Belarus"));
        }
        [TestMethod]
        public void CheckValidDiscountPositive()
        {
            DiscountOrder order = new DiscountOrder("Mouse", 5159487263951, 12, "Lida", 5);
            Assert.AreEqual(5, order.Discount);
        }
        [TestMethod]
        public void CheckValidDiscountNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new DiscountOrder("Mouse", 5159487263951, 12, "Lida", 7));
        }
        [TestMethod]
        public void CheckValidGiftPositive()
        {
            VIPOrder order = new VIPOrder("IPhone", 3567891235412, 598, "Gomel", "GIFT");
            Assert.AreEqual("GIFT", order.Gift);
        }
        [TestMethod]
        public void CheckValidGiftNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new VIPOrder("IPhone", 3567891235412, 598, "Gomel", "NOTHING"));
        }
        [TestMethod]
        public void CheckValidAddOrderAndRemoveOrderDeliveryServicePositive()
        {
            DeliveryService deliveryService = new DeliveryService("DPD");
            OrdinaryOrder ordinary = new OrdinaryOrder("TV", 7844124802909, 123, "Vitebsk");
            deliveryService.AddOrder(ordinary);
            Assert.IsTrue(deliveryService._orders.Contains(ordinary));
            deliveryService.RemoveOrder(ordinary);
            Assert.IsFalse(deliveryService._orders.Contains(ordinary));
        }
        [TestMethod]
        public void CheckValidAddDeliveryAndRemoveDeliveryDeliveryServicePositive()
        {
            DeliveryService deliveryService = new DeliveryService("DPD");
            WalkingDelivery walking = new WalkingDelivery("Vasia");
            deliveryService.AddDelivery(walking);
            Assert.IsTrue(deliveryService._deliveries.Contains(walking));
            deliveryService.RemoveDelivery(walking);
            Assert.IsFalse(deliveryService._deliveries.Contains(walking));
        }
    }
}