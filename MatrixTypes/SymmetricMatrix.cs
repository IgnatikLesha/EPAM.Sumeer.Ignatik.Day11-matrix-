using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTypes
{
    public class SymmetricMatrix<T>:SquareMatrix<T>
    {
        public SymmetricMatrix()
        {
        }

        public SymmetricMatrix(T[,] coeff) : base(coeff)
        {
            if (!IsSymmetric(coeff))
                throw new ArithmeticException();
        }
 
        private bool IsSymmetric(T[,] matrix)
        {
            bool statement = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (!Equals(matrix[i, j], matrix[j, i]))
                        statement = false;
            return statement;
        }
    }
}
