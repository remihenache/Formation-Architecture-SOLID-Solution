namespace SOLIDPrinciples_06.Solution.DIP;

public interface IIventoryService
{
    bool CheckInventory(Order order);
}

public class FakeInventoryService : IIventoryService
{
    public bool CheckInventory(Order order)
    {
        // Check if items are in stock
        return true; // Simplified for example
    }
}