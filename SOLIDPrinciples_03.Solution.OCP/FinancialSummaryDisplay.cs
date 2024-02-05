using SOLIDPrinciples_03.Solution.OCP.Data;
using SOLIDPrinciples_03.Solution.OCP.Display;

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

