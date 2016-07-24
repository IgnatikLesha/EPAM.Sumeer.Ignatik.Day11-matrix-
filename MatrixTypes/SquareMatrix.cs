using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTypes
{
    public class SquareMatrix<T>: IMatrix<T>
    {
        
        private readonly int dimension;
        private readonly T[,] coeff;
        protected event EventHandler<MatrixEventArgs> Message;

        public SquareMatrix()
        {
            coeff = new T[1, 1];
        }

        public SquareMatrix(T[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
                throw new ArgumentNullException();

            dimension = matrix.GetLength(0);
            coeff = matrix;
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

        public T this[int i, int j]
        {

            get
            {
                if ((i < 0 || j < 0) || (i > dimension || j > dimension))
                    throw new ArgumentOutOfRangeException();
                return coeff[i, j];
            }
            set
            {
                if ((i < 0 || j < 0) || (i > dimension || j > dimension))
                    throw new ArgumentOutOfRangeException();
                coeff[i, j] = value;
                OnElementChenges(new MatrixEventArgs("Element (i,j): (" + i + "," + j + ") changes in square matrix"));
            }
        }

        public string ToString()
        {
            if (ReferenceEquals(coeff, null))
            {
                return "";
            }
            var result = new StringBuilder();
            for (var i = 0; i < coeff.GetLength(0); i++)
            {
                for (var j = 0; j < coeff.GetLength(1); j++)
                {
                    if (ReferenceEquals(coeff[i, j], null)) result.Append("null ");
                    else result.Append(coeff[i, j] + " ");
                }
                result.Append("\n");
            }
            return result.ToString();
        }

        public IEnumerable<T> GetMatrix()
        {
            foreach (var item in coeff)
            {
                yield return item;
            }
        }

        private void OnElementChenges(MatrixEventArgs e)
        {
            if (Message != null)
                Message.Invoke(this, e);
        }


    }
}

