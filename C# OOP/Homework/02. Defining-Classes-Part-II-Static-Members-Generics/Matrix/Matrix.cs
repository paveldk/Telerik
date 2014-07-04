namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    // struct are numbers so it's fine
    public class Matrix<T> where T : struct
    {
        private const int DefaultSize = 2;
        private T[,] matrix;       

        // one constructor for default size(atm 4)
        public Matrix()
        {
            this.matrix = new T[DefaultSize, DefaultSize];
            this.Row = DefaultSize;
            this.Col = DefaultSize;
        }

        // one with client size
        public Matrix(int row, int col)
        {
            if (row < 0 || col < 0)
            {
                throw new ArgumentOutOfRangeException("Negative row or col value");
            }
            else
            {
                this.Row = row;
                this.Col = col;
                this.matrix = new T[row, col];
            }
        }

        // and one with matrix as parameter
        public Matrix(T[,] matrix)
        {
            this.matrix = matrix;
            this.Row = matrix.GetLength(0);
            this.Col = matrix.GetLength(1);
        }

        public int Row { get; private set; }

        public int Col { get; private set; }

        // The indexer
        public T this[int row, int col]
        {
            get
            {
                if (this.Row < row || this.Col < col || row < 0 || col < 0)
                {
                    throw new ArgumentOutOfRangeException("Index out of range for Row or Col");
                }
                else
                {
                    return this.matrix[row, col];
                }
            }

            set
            {
                if (this.Row < row || this.Col < col || row < 0 || col < 0) 
                {
                    throw new ArgumentOutOfRangeException("Index out of range for Row or Col");
                }
                else
                {
                    this.matrix[row, col] = value;
                }
            }
        }

        /*And the Operator overloading, simply Add, Substract or multiply element by element
         * IF the matrix are equal, if not - Exception
         * */

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.Col == second.Col && first.Row == second.Row)
            {
                Matrix<T> result = new Matrix<T>(first.Row, first.Col);
                for (int row = 0; row < result.Row; row++)
                {
                    for (int col = 0; col < result.Col; col++)
                    {
                        result[row, col] = (dynamic)first[row, col] + second[row, col];
                    }
                }

                return result;
            }
            else
            {
                throw new Exception("The given matrix are not with the same column and row size");
            }
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Col == second.Col && first.Row == second.Row)
            {
                Matrix<T> result = new Matrix<T>(first.Row, first.Col);
                for (int row = 0; row < result.Row; row++)
                {
                    for (int col = 0; col < result.Col; col++)
                    {
                        result[row, col] = (dynamic)first[row, col] - second[row, col];
                    }
                }

                return result;
            }
            else
            {
                throw new Exception("The given matrix are not with the same column and row size");
            }
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Col == second.Col && first.Row == second.Row)
            {
                Matrix<T> result = new Matrix<T>(first.Row, first.Col);
                for (int row = 0; row < result.Row; row++)
                {
                    for (int col = 0; col < result.Col; col++)
                    {
                        result[row, col] = (dynamic)first[row, col] * second[row, col];
                    }
                }

                return result;
            }
            else
            {
                throw new Exception("The given matrix are not with the same column and row size");
            }
        }      
    }
}
