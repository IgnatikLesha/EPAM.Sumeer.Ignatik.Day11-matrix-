using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTypes
{
    public interface IVisitor<T>
    {
        void Visit(AbstractMatrix<T> lhs, AbstractMatrix<T> rhs);
    }
}
