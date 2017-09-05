using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DP
{
    class Program
    {
        static void Main(string[] args)
        {
            var j=new Journal();
            j.AddEntry("I criend today");
            j.AddEntry("I ate bug");
            Console.WriteLine(j);

            var p=new Persistence();
            var filename = @"c:\temp\journal.txt";
            p.Save(j,filename,true);
            Process.Start(filename);
        }
    }
}
