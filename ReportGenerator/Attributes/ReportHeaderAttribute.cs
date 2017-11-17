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
        private int orderNumber;

        public virtual string Name
        {
            get { return name; }
        }
        public virtual int OrderNumber
        {
            get { return orderNumber; }
        }

        public ReportHeaderAttribute(string name, int orderNumber)
        {
            this.name = name;
            this.orderNumber = orderNumber;
        }
    }
}
