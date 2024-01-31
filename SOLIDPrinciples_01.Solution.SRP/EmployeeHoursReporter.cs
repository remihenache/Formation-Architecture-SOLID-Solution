namespace SOLIDPrinciples_01.Solution.SRP;

public class EmployeeHoursReporter
{
    private Employee employee;

    public EmployeeHoursReporter(Employee employee)
    {
        this.employee = employee;
    }

    public int ReportHours()
    {
        int hours = employee.RegularHours;
        // Additional reporting logic
        return hours;
    }
}