namespace SOLIDPrinciples_03.Solution.OCP;

public class FinancialSummaryDisplay
{
    private FinancialDisplay display;

    public void UseDisplay(FinancialDisplay display)
    {
        this.display = display;
    }
    
    public string Display(FinancialDataProvider dataProvider)
    {
        FinancialData data = dataProvider.GetData();
        return display.Display(data);
    }
}

public interface FinancialDisplay
{
    string Display(FinancialData data);
}

public class FinancialSummaryDisplayOnWeb : FinancialDisplay
{
    public string Display(FinancialData data)
    {
        // Logic to format and display data on the web
        // Negative numbers in red, scrollable content, etc.
        return $"Web Display Value: {data.Value}";
    }
}

public class FinancialSummaryDisplayForPrint : FinancialDisplay
{
    public string Display(FinancialData data)
    {
        // Logic to format and display data on the web
        // Negative numbers in red, scrollable content, etc.
        return $"Print report Value: {data.Value}";
    }
}

public interface FinancialDataProvider
{
    FinancialData GetData();
}

public class InMemoryFinancialDataProvider: FinancialDataProvider
{
    public FinancialData GetData() => new FinancialData()
    {
        Value = "In Memory Value"
    };
}
public class FinancialData
{
    public string Value { get; set; }
}
