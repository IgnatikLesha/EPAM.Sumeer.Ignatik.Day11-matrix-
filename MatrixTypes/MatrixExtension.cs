using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTypes
{
    public static class MatrixExtension
    {
        public static AbstractMatrix<T> Add<T>(this AbstractMatrix<T> lhs, AbstractMatrix<T> rhs)
        {
            var visitor = new Visitor<T>();
            lhs.Accept(visitor, rhs);
            return visitor.Result;
        }
    }
}
