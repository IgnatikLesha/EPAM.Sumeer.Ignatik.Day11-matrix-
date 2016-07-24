using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTypes
{
    public interface IMatrix<T>
    {
        int Dimension { get; }
        T this[int i, int j] { get; set; }
    }
}
