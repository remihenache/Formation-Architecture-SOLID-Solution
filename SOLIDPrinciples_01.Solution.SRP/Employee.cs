namespace SOLIDPrinciples_01.Solution.SRP;

public class Employee
{
    public int RegularHours { get; private set; }
    public decimal HourlyRate { get; set; }

    public Employee(int regularHours)
    {
        RegularHours = regularHours;
    }

    // Other employee-related properties and methods
}