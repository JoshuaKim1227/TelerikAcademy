namespace DefiningClasses_II.Core
{
    using System;

    public class Matrix<T> where T : IComparable, IFormattable, IConvertible, IComparable<int>, IEquatable<int>
    {
        // Initializing data types
        private T[,] matrix;
        private int sizeRow;
        private int sizeCol;

        // Constructor
        public Matrix(int row, int col)
        {
            this.sizeRow = row;
            this.sizeCol = col;
            this.matrix = new T[row, col];
        }

        // Indexer
        public T this[int row, int col]
        {
            get
            {
                if (row <= this.sizeRow && col <= this.sizeCol)
                {
                    return this.matrix[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }

            set
            {
                if (row <= this.sizeRow && col <= this.sizeCol)
                {
                    this.matrix[row, col] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        // Adding matrixes method
        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.sizeRow, matrix1.sizeCol);

            if (matrix1.sizeRow == matrix2.sizeRow && matrix1.sizeCol == matrix2.sizeCol)
            {
                for (int row = 0; row < matrix1.sizeRow; row++)
                {
                    for (int col = 0; col < matrix1.sizeCol; col++)
                    {
                        resultMatrix[row, col] = (dynamic)matrix1[row, col] + matrix2[row, col];
                    }
                }

                return resultMatrix;
            }
            else
            {
                throw new ArgumentException("The size of the matrixes must be the same.");
            }
        }

        // Subtracting matrixes method
        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.sizeRow, matrix1.sizeCol);

            if (matrix1.sizeRow == matrix2.sizeRow && matrix1.sizeCol == matrix2.sizeCol)
            {
                for (int row = 0; row < matrix1.sizeRow; row++)
                {
                    for (int col = 0; col < matrix1.sizeCol; col++)
                    {
                        resultMatrix[row, col] = (dynamic)matrix1[row, col] - matrix2[row, col];
                    }
                }

                return resultMatrix;
            }
            else
            {
                throw new ArgumentException("The size of the matrixes must be the same.");
            }
        }

        // Multiplaying matrixes method
        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            Matrix<T> resultMatrix = new Matrix<T>(matrix1.sizeRow, matrix1.sizeCol);

            if (matrix1.sizeRow == matrix2.sizeRow && matrix1.sizeCol == matrix2.sizeCol)
            {
                for (int row = 0; row < matrix1.sizeRow; row++)
                {
                    for (int col = 0; col < matrix1.sizeCol; col++)
                    {
                        resultMatrix[row, col] = (dynamic)matrix1[row, col] * matrix2[row, col];
                    }
                }

                return resultMatrix;
            }
            else
            {
                throw new ArgumentException("The size of the matrixes must be the same.");
            }
        }

        // Check for non-zero elements
        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.sizeRow; row++)
            {
                for (int col = 0; col < matrix.sizeCol; col++)
                {
                    if ((dynamic)matrix[row, col] != 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.sizeRow; row++)
            {
                for (int col = 0; col < matrix.sizeCol; col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override string ToString()
        {
            string info = string.Empty;

            for (int row = 0; row < this.sizeRow; row++)
            {
                for (int col = 0; col < this.sizeCol; col++)
                {
                    info += string.Format("{0} ", this.matrix[row, col]);
                }

                info += "\n";
            }

            return info;
        }
    }
}