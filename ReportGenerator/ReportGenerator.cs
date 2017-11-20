using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportGenerator.Attributes;

namespace ReportGenerator
{
    public abstract class ReportGenerator<T> : IReportGenerator<T>
    {

        private string ReportTitle;

        public string Title
        {
            get { return this.ReportTitle; }
        }

        public Dictionary<int, string> Headers
        {
            get { return this.ReportHeaders; }
        }
        private Dictionary<int, string> ReportHeaders;
        public ReportGenerator()
        {
            GetReportTitle();
            GetReportHeaders();

        }

        public string Discover()
        {
            try
            {
                //Get Report Header
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }


        private void GetReportTitle()
        {
            try
            {
                ReportTitleAttribute reportTitle = (ReportTitleAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(ReportTitleAttribute));
                if (reportTitle == null)
                {
                    throw new Exception($"");
                }
                this.ReportTitle = reportTitle.Title;
            }
            catch (Exception ex)
            {
            }
        }

        private List<int> sortNumber = new List<int>();
        private void GetReportHeaders()
        {
            try
            {
                var headers = new Dictionary<int, string>();
                var members = typeof(T).GetProperties();

                foreach (var member in members)
                {
                    var reportHeader = (ReportHeaderAttribute)Attribute.GetCustomAttribute(member, typeof(ReportHeaderAttribute));
                    if (reportHeader != null)
                    {
                        headers.Add(reportHeader.OrderNumber, reportHeader.Name);
                        sortNumber.Add(reportHeader.OrderNumber);
                    }
                }
                this.ReportHeaders = headers.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                //ReportHeaders.OrderBy(x => x.Key);


            }
            catch (Exception ex)
            {
            }
        }

        // public abstract IEnumerator<T> GetEnumerator();



        public void Generate(IEnumerable<T> model)
        {
            try
            {
                Dictionary<int, System.Reflection.PropertyInfo> reportPropertiesDictionary = new Dictionary<int, System.Reflection.PropertyInfo>();
               // List<string> reportName = new List<string>();
                Type reportType = typeof(T);
                var propertyArray = reportType.GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(ReportHeaderAttribute)));
                var propertyAndSort = propertyArray.Zip(sortNumber, (p, s) => new { propertyArray = p, sortNumber = s });
                //iterate two lists with one foreach
                foreach(var ps in propertyAndSort)
                {
                    reportPropertiesDictionary.Add(ps.sortNumber, ps.propertyArray);
                    //reportName.Add(ps.propertyArray.Name);
                }

                var sortedReportPropertiesDictionary = reportPropertiesDictionary.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                
                foreach(var reportProp in sortedReportPropertiesDictionary)
                {
                    foreach(var report in model)
                    {
                        string reportFinal = reportProp.Value.GetValue(report).ToString();
                        Console.Write("{0,-20}", reportFinal);
                    }
                    Console.WriteLine("");
                   
                }
                



            }
            catch (Exception)
            {
                //Console.WriteLine("Some error occured");
                throw;
            }
        }
    }
}
