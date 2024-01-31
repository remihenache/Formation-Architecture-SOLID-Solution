namespace SOLIDPrinciples_06.Solution.DIP;

public interface IShippingService
{
    void ScheduleShipping(Order order);
}

public class FakeShippingService : IShippingService
{
    public void ScheduleShipping(Order order)
    {
        // Logic to schedule shipping
    }
}