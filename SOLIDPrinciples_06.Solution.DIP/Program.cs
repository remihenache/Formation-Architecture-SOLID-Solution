namespace SOLIDPrinciples_06.Solution.DIP;

public static class Program
{
    public static void Main()
    {
        var order = new Order();
        new OrderProcessingService(
            new FakeInventoryService(),
            new FakePaymentService(),
            new FakeShippingService()
            ).ProcessOrder(order);
    }
}