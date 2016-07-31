using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTypes
{
    public class DiagonalMatrix<T>: AbstractMatrix<T>
    {
        private T[] coeff;
        protected override void SetElement(int i, int j, T val)
        {
            if (i < Dimension || j < Dimension)
                throw new ArgumentException();
            if (i!=j)
                throw new ArgumentException("Not diagonal element");
            else
            {
                coeff[i] = val;
            }
        }

        protected override T GetElement(int i, int j)
        {
            if (i < Dimension || j < Dimension)
                throw new ArgumentException();
            return coeff[i*Dimension + j];
        }




        
        private bool IsDioganal(T[,] cff)
        {
            bool statement = true;
            for (int i = 0; i < coeff.GetLength(0); i++)
                for (int j = i + 1; j < coeff.GetLength(1); j++)
                    if (!Equals(cff[i, j], default(T)))
                        statement = false;
            return statement;
        }
    }
}
