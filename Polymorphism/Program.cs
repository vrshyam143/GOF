using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            const int hours = 50, wage=70;
            Employee person=new Employee();
            person.CalculateWeeklySalary(hours,wage);

            Contractor contractor=new Contractor();
            contractor.CalculateWeeklySalary(hours,wage);

        }
    }
}
