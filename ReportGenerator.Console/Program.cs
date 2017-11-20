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

            var sampleModelObject1 = new SampleModel(15, "Tola", "Lagos", "female");
            var sampleModelObject2 = new SampleModel(23, "Deji", "Lagos", "male");
            var sampleModelObject3 = new SampleModel(32, "Uzo", "Lagos", "male");
            var sampleModelObject4 = new SampleModel(44, "Bala", "Lagos", "female");

            List<SampleModel> sampleList = new List<SampleModel>();
            sampleList.Add(sampleModelObject1);
            sampleList.Add(sampleModelObject2);
            sampleList.Add(sampleModelObject3);
            sampleList.Add(sampleModelObject4);

            
            System.Console.WriteLine($"##################{reportTitle}#################");
            System.Console.WriteLine();
            System.Console.WriteLine();
            
            //try
            //{
                foreach (var header in reportHeaders)
                {
                    System.Console.Write("{0,-20}", header.Value); //formats the string with spacing and alignments
                }
                System.Console.WriteLine();
                reportGenerator.Generate(sampleList);
                System.Console.ReadLine();
            //}
            //catch
            //{
            //    System.Console.WriteLine("Error occured!");  //vague error
            //}
        }
    }
}
