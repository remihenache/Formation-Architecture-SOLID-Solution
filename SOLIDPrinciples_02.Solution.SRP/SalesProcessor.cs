namespace SOLIDPrinciples.Solution.SRP;

public class SalesProcessor
{
    private InventoryManager inventoryManager;
    private InvoiceGenerator invoiceGenerator;

    public SalesProcessor(InventoryManager inventoryManager, InvoiceGenerator invoiceGenerator)
    {
        this.inventoryManager = inventoryManager;
        this.invoiceGenerator = invoiceGenerator;
    }

    public void ProcessSale(string bikeModel, int quantity)
    {
        double cost = inventoryManager.GetBikeCost(bikeModel) * quantity;
        inventoryManager.UpdateInventory(bikeModel, quantity);
        invoiceGenerator.GenerateInvoice(bikeModel, quantity, cost);
    }
}