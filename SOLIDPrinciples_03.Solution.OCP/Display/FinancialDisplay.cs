using SOLIDPrinciples_03.Solution.OCP.Data;

namespace SOLIDPrinciples_03.Solution.OCP.Display;

public interface FinancialDisplay
{
    string Display(FinancialData data);
}