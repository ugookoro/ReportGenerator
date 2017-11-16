using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportGenerator
{
    public interface IReportGenerator<T>
    {
        void Generate(IEnumerable<T> model);
        string Discover();
    }
}
