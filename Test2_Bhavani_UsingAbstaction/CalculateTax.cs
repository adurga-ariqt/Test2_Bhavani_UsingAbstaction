using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Bhavani_UsingAbstaction
{
    public  class CalculateTax:  EmployeeInformation
    {
        public double Tax { get; set; }
        public Double TotalAmount { get; set; }
        public override void EmployeeDetails()
        {
            
            string ename;
            int age;
            int id;
            Console.WriteLine("Enter employ name:");
            ename = Console.ReadLine();
            Console.WriteLine("Enter employee age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee Id:");
            id = Convert.ToInt32(Console.ReadLine());
        }
        public void CalculateEmployeeNetSalaryWithTax()
        {
            double hra = 100;
            double ta = 100;
            double da = 100;
            double salary = 30000;
            double netSalary = hra + ta + da + salary;
            Console.WriteLine("Employee netsalary is :" + netSalary);
             if (netSalary > 10000)
             {
                Tax = 2000;
                Console.WriteLine("Employee tax is :" + Tax);
            }
            else
            {
                Tax = 500;
                Console.WriteLine("Employee Tax is :" + Tax);
            }

            TotalAmount = netSalary - Tax;
            Console.WriteLine("The total ampount is :" + TotalAmount);
            TotalAmount = Convert.ToInt32(Console.ReadLine());
        }
        
    }
}
