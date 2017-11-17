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

        public int Age { get; set; }

        [ReportHeader("Fullname")]
        public string Name { get; set; }

        [ReportHeader("Origin")]
        public string State { get; set; }

        [ReportHeader("Gender")]
        public string Sex { get; set; }

    }
}
