using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    public class Employee
    {
        public string Name;
        public int ID;
        public decimal Salary;

        public Employee(string name, int id, decimal salary)
        {
            Name = name;
            ID = id;
            Salary = salary;
        }
        public virtual decimal CalculateAnnualSalary()
        {
            return 12 * Salary;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name:{Name}, ID: {ID}, Annual Salary:{CalculateAnnualSalary()}");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public decimal Bonus { get; set; }
        public FullTimeEmployee(string name, int id, decimal salary, decimal bonus) : base(name, id, salary)
        {
            Bonus = bonus;
        }
        public override decimal CalculateAnnualSalary()
        {
            return Salary * 12 + Bonus;
        }
    }
    public class PartTimeEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public PartTimeEmployee(string name,int id,decimal hourlyRate):base(name,id, hourlyRate)
        {
            HourlyRate = hourlyRate;
        }
        public override decimal CalculateAnnualSalary()
        {
            return (HourlyRate * 4) * 5 * 52; //4 ore de lucru pe zi, 5 zile pe saptamana, 52 saptamani
        }

    }
}
