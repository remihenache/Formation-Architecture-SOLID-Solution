using SOLIDPrinciples_03.Solution.OCP.Data;

namespace SOLIDPrinciples_03.Solution.OCP.Display;

public class FinancialDisplayForPrint : FinancialDisplay
{
    public string Display(FinancialData data)
    {
        // Logic to format and display data on the web
        // Negative numbers in red, scrollable content, etc.
        return $"Print report Value: {data.Value}";
    }
}