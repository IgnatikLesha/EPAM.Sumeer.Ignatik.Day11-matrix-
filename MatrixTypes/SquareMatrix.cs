using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTypes
{
    public class SquareMatrix<T>: AbstractMatrix<T>
    {
        
        private readonly int dimension;
        private readonly T[] coeff;
        protected event EventHandler<MatrixEventArgs> Message;



        public SquareMatrix()
        {
            coeff = new T[1];
        }

        public SquareMatrix(int n)
        {
            dimension = n;
        }

        public SquareMatrix(T[] matrix)
        {
            if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
                throw new ArgumentNullException();

            dimension = matrix.GetLength(0);
            coeff = matrix;
        }

        protected override T GetElement(int i, int j)
        {
            if (i < Dimension || j < Dimension)
                throw new ArgumentException();
            return coeff[i*Dimension + j];
        }

        protected override void SetElement(int i, int j, T val)
        {
            if (i < Dimension || j < Dimension)
                throw new ArgumentException();
            coeff[i*Dimension + j] = val;
        }

        public int Dimension
        {
            get
            {
                if (coeff == null)
                    throw new ArgumentNullException();
                return dimension;
            }
        }



    }
}

