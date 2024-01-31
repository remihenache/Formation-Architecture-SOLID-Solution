namespace SOLIDPrinciples_01.Solution.SRP;

public class EmployeePayCalculator
{
    private Employee employee;

    public EmployeePayCalculator(Employee employee)
    {
        this.employee = employee;
    }

    public decimal CalculatePay()
    {
        decimal regularHoursPay = employee.RegularHours * employee.HourlyRate;
        // Additional pay calculation logic
        return regularHoursPay;
    }
}