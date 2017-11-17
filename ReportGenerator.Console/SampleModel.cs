using ReportGenerator.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator.Console
{

    [ReportTitle("SAMPLE REPORT TITLE")]
    public class SampleModel
    {
        [ReportHeader("Age",2)]
        public int Age { get; set; }

        [ReportHeader("Fullname",0)]
        public string Name { get; set; }

        [ReportHeader("Origin",3)]
        public string State { get; set; }

        [ReportHeader("Gender",1)]
        public string Sex { get; set; }

    }
}
