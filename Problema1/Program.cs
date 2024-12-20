namespace Problema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee employeeOne = new FullTimeEmployee("Igor", 101, 1500, 1500);
            employeeOne.DisplayInfo();
            PartTimeEmployee employeeTwo = new PartTimeEmployee("Gabriel", 102, 12);
            employeeTwo.DisplayInfo();
        }
    }
}
