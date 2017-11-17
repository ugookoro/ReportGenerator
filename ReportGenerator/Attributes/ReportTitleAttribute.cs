using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ReportTitleAttribute : Attribute
    {
        public string Title { get; }
        public ReportTitleAttribute(string title)
        {
            this.Title = title;
        }
    }
}
