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

        public List<string> Headers
        {
            get { return this.ReportHeaders; }
        }
        private List<string> ReportHeaders;
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

        private void GetReportHeaders()
        {
            try
            {
                var headers = new List<string>();
                var members = typeof(T).GetProperties();

                foreach (var member in members)
                {
                    var reportHeader = (ReportHeaderAttribute) Attribute.GetCustomAttribute(member, typeof(ReportHeaderAttribute));
                    if (reportHeader != null)
                    {
                        headers.Add(reportHeader.Name);
                    }
                }
                this.ReportHeaders = headers;
                
            }
            catch (Exception ex)
            {
            }
        }

        public void Generate(IEnumerable<T> model)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
