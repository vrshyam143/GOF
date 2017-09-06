using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee
    {
        public virtual void CalculateWeeklySalary(int weeklyhours, int wage)
        {
            var salary = 40 * wage;
            Console.WriteLine("\nThis Employee worked {0} hrs. " + "Paid for 40hrs (no overtime) at ${1} hr = ${2}", weeklyhours,wage, salary);
            Console.WriteLine("------------------------------------------------------------------------------------");

        }
    }

   
}
