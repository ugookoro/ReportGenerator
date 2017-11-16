using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class ReportHeaderAttribute : Attribute
    {
        private string name;

        public virtual string Name
        {
            get { return name; }
        }

        public ReportHeaderAttribute(string name)
        {
            this.name = name;
        }
    }
}
