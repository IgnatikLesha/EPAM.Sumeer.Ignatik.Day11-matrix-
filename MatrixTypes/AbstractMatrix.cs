using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTypes
{
    public abstract class AbstractMatrix<T>
    {
        public int Dimension { get; protected set; }

        public event EventHandler<MatrixEventArgs> ChangeElement = delegate { };

        public virtual void Accept(IVisitor<T> visitor, AbstractMatrix<T> other)
        {
            visitor.Visit((dynamic)this, (dynamic)other);
        }

        protected abstract void SetElement(int i, int j, T val);

        protected abstract T GetElement(int i, int j);


        public virtual T this[int i, int j]
        {
            get
            {
                if (i < 0 || j < 0 || i > Dimension || j > Dimension)
                    throw new ArgumentException();
                return GetElement(i, j);
            }
            set
            {
                if (i < 0 || j < 0 || i > Dimension || j > Dimension)
                    throw new ArgumentException();
                SetElement(i, j, value);
                OnNewMail(new MatrixEventArgs(string.Format(" i={0}, j={1} element is {2} now ", i, j, value)));
            }
        }



        protected virtual void OnNewMail(MatrixEventArgs e)
        {
            EventHandler<MatrixEventArgs> temp = ChangeElement;

            if (!ReferenceEquals(temp, null))
            {
                temp(this, e);
            }
        }
    }
}

