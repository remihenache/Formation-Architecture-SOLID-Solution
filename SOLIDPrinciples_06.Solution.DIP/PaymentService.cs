namespace SOLIDPrinciples_06.Solution.DIP;

public interface IPaymentService
{
    bool ProcessPayment(Order order);
}

public class FakePaymentService: IPaymentService
{
    public bool ProcessPayment(Order order)
    {
        // Process the payment
        return true; // Simplified for example
    }
}