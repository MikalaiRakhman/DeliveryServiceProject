using DeliveryServiceProject.TypeOfOrders;
using DeliveryServiceProject.ItemsDelivery;
namespace DeliveryServiceProject
{
    /// <summary>
    /// Class for testing program code
    /// </summary>
    public class RunProgram
    {
        static void Main(string[] args)
        {
            DeliveryService deliveryService = new DeliveryService("DPD");
            try
            {
                deliveryService.AddOrder(new OrdinaryOrder("TV", 7844124802909, 123, "Vitebsk"));
                deliveryService.AddOrder(new VIPOrder("Panasonic", 1572068230237, 321, "Brest", "gift1"));
                deliveryService.AddOrder(new DiscountOrder("HP", 2412478412389, 357, "Berezovka", 20));
                deliveryService.AddOrder(new OrdinaryOrder("TV", 8682305722358, 78, "Minsk"));
                deliveryService.AddOrder(new VIPOrder("IPhone", 3567891235412, 598, "Gomel", "NOTHING awdefaw"));
                deliveryService.AddOrder(new DiscountOrder("Mouse", 5159487263951, 12, "Lida", 5));
                deliveryService.AddDelivery(new WalkingDelivery("Vasia"));
                deliveryService.AddDelivery(new AutoDelivery("Skoda", "Kolia"));
                deliveryService.AddDelivery(new MotoDelivery("Suzuki", "Georgy"));
                deliveryService.AddDelivery(new DronDelivery("T-1000"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            deliveryService.MakeDelivery("TV");
            deliveryService.MakeDelivery("IPhone");
            deliveryService.MakeDelivery("Mouse");
            Console.WriteLine();
        }
    }
}
