using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTypes
{
    public class SymmetricMatrix<T>: AbstractMatrix<T>
    {
        private T[] coeff;

        public SymmetricMatrix() : this(new T[1])
        {
        }


        public SymmetricMatrix(T[] coeff) 
        {
            if (!IsSymmetric(coeff))
                throw new ArithmeticException();
            else
            {
                coeff = coeff;
            }
        }

        protected override void SetElement(int i, int j, T val)
        {
            if (i < Dimension || j < Dimension)
                throw new ArgumentException();
            coeff[i * Dimension + j] = val;
            coeff[j*Dimension + i] = val;
        }

        protected override T GetElement(int i, int j)
        {
            if(i < Dimension || j < Dimension)
                throw new ArgumentException();
            return coeff[i * Dimension + j];
        }

        private bool IsSymmetric(T[] matrix)
        {
            bool symmetric = true;
            int length = (int)Math.Sqrt(matrix.Length);
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    if (!Equals(matrix[i*length + j], matrix[j*length + i]))
                    {
                        return false;
                    }
            return true;
        }
    }
}
