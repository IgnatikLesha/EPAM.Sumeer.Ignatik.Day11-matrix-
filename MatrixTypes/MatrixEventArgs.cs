using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTypes
{
    public class MatrixEventArgs: EventArgs
    {
        private readonly string message;

        public MatrixEventArgs(string report)
        {
            if (report == null)
                throw new ArgumentNullException("report");
            message = report;
        }

        public string Message { get { return message; } }

    }
}
