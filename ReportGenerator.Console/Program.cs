using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var reportGenerator = new SampleModelReportGenerator();

            var reportTitle = reportGenerator.Title;
            var reportHeaders = reportGenerator.Headers;

            System.Console.WriteLine($"##################{reportTitle}#################");
            System.Console.WriteLine();
            reportHeaders.ForEach(x => { System.Console.Write($"{x} | "); });

            System.Console.ReadLine();

        }
    }
}
