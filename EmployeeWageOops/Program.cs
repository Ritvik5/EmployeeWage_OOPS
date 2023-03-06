namespace EmployeeWageOops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeWage  dmart = new EmployeWage("DMart", 20, 2, 10);
            EmployeWage  reliance = new EmployeWage("Reliance", 20, 2, 10);
            dmart.ComputeEmpWage();
            Console.WriteLine(dmart.GetCompany());
            reliance.ComputeEmpWage();
            Console.WriteLine(reliance.GetCompany());
        }
    }
}