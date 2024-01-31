namespace SOLIDPrinciples_03.Solution.OCP.Data;

public class InMemoryFinancialDataProvider: FinancialDataProvider
{
    public FinancialData GetData() => new FinancialData()
    {
        Value = "In Memory Value"
    };
}