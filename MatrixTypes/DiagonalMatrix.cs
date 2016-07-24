using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTypes
{
    class DiagonalMatrix<T>: SymmetricMatrix<T>
    {
        public DiagonalMatrix(T[,] coeff) : base(coeff)
        {
            if (!IsDioganal(coeff))
                throw new ArgumentNullException();
        }

        public DiagonalMatrix(T[] diagonalcoeff) : this(new T[diagonalcoeff.Length, diagonalcoeff.Length])
        {
            if (diagonalcoeff == null)
                throw new ArgumentNullException();
            for (int i = 0; i < Dimension; i++)
                this[i, i] = diagonalcoeff[i];
        }
        
        private bool IsDioganal(T[,] coeff)
        {
            bool statement = true;
            for (int i = 0; i < coeff.GetLength(0); i++)
                for (int j = i + 1; j < coeff.GetLength(1); j++)
                    if (!Equals(coeff[i, j], default(T)))
                        statement = false;
            return statement;
        }
    }
}
