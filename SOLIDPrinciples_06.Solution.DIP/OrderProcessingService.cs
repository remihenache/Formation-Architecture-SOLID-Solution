namespace SOLIDPrinciples_06.Solution.DIP;

public class OrderProcessingService
{
    private readonly IIventoryService inventoryService;
    private readonly IPaymentService paymentService;
    private readonly IShippingService shippingService;

    public OrderProcessingService(
        IIventoryService inventoryService,
        IPaymentService paymentService, 
        IShippingService shippingService)
    {
        this.inventoryService = inventoryService;
        this.paymentService = paymentService;
        this.shippingService = shippingService;
    }
    public void ProcessOrder(Order order)
    {
        if (inventoryService.CheckInventory(order) && paymentService.ProcessPayment(order))
        {
            shippingService.ScheduleShipping(order);
            Console.WriteLine("Order processed successfully.");
        }
        else
        {
            Console.WriteLine("Order processing failed.");
        }
    }
}