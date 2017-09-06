using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Contractor : Employee
    {
        public override void CalculateWeeklySalary(int weeklyhours, int wage)
        {
            var salary = weeklyhours * wage;
            Console.WriteLine("\nThis Contractor worked {0} hrs. " + "Paid for {0} hrs (w/ overtime) at ${1} hr = ${2}", weeklyhours, wage, salary);
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
    }
}
