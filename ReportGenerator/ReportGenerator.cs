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
                ReportHeaderAttribute[] reportHeaders = (ReportHeaderAttribute[])Attribute.GetCustomAttributes(typeof(T), typeof(ReportHeaderAttribute));
                if (reportHeaders == null)
                {
                    throw new Exception("");
                }
                this.ReportHeaders = reportHeaders.Select(x => x.Name).ToList();
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
