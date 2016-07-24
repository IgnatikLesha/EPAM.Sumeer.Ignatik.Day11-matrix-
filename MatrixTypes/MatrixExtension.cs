using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTypes
{
    public static class MatrixExtension
    {
        public static IMatrix<T> AddMatrix<T>(this IMatrix<T> lhsMatrix, IMatrix<T> rhsMatrix)
        {
            if (lhsMatrix == null || rhsMatrix == null)
                throw new ArgumentNullException();

            if (lhsMatrix.Dimension != rhsMatrix.Dimension)
                throw new ArithmeticException();

            IMatrix<T> temp = new SquareMatrix<T>(new T[lhsMatrix.Dimension, lhsMatrix.Dimension]);
            for (int i = 0; i < lhsMatrix.Dimension; i++)
                for (int j = 0; j < lhsMatrix.Dimension; j++)
                    temp[i, j] = (dynamic)lhsMatrix[i, j] + (dynamic)rhsMatrix[i, j];
            return temp;
        }
    }
}
