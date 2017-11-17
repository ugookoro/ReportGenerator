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
            System.Console.WriteLine();
            // reportHeaders.ForEach(x => { System.Console.Write("{0,-20}",x); }); //formats the string with spacing and alignments
            try
            {
                foreach (var header in reportHeaders)
                {
                    System.Console.Write("{0,-20}", header.Value); //formats the string with spacing and alignments
                }
                System.Console.ReadLine();
            }
            catch
            {
                System.Console.WriteLine("Error occured!");  //vague error
            }
        }
    }
}
