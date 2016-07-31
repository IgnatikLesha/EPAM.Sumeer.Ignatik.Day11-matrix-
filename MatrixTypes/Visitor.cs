using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTypes
{
    class Visitor<T>: IVisitor<T>
    {
        public AbstractMatrix<T> Result { get; private set; }

        public void Visit(AbstractMatrix<T> lhs, AbstractMatrix<T> rhs)
        {

            if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null))
                throw new ArgumentNullException();

            if (lhs.Dimension != rhs.Dimension)
                throw new ArgumentException();

            Result = new SquareMatrix<T>(rhs.Dimension);

            for (int i = 0; i < lhs.Dimension; i++)
            {
                for (int j = 0; j < rhs.Dimension; j++)
                {
                    try
                    {
                        Result[i + 1, j + 1] = (T)((dynamic)lhs[i + 1, j + 1] + rhs[i + 1, j + 1]);
                    }
                    catch (Exception)
                    {
                        throw new ArgumentException();
                    }
                }
            }
        }
    }
}
