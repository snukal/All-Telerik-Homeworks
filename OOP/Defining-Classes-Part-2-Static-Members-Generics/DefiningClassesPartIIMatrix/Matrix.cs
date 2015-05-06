namespace DefiningClassesPartIIMatrix
{
    using System;
    using System.Text;
    public class Matrix<T> 
    {
        private int rows;                   
        private int cols;                   
        private T[,] theMatrix;             
                                            
        public int Rows                     
        {
            get
            {
                return this.theMatrix.GetLength(0);
            }
        }
        public int Cols                     
        {
            get
            {
                return this.theMatrix.GetLength(1);
            }
        }

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.theMatrix = new T[rows, cols];
        }

        public Matrix(T[,] predefined) 
        {
            this.theMatrix = predefined;
            this.rows = theMatrix.GetLength(0);
            this.cols = theMatrix.GetLength(1);
        }

        public T this[int rowsIndex, int colsIndex]
        {
            get 
            {
                if (rowsIndex > this.rows -1 || rowsIndex <0)
                {
                    throw new IndexOutOfRangeException(string.Format("Index {0} is out of range!", rowsIndex));
                }
                if (colsIndex > this.rows - 1 || colsIndex < 0)
                {
                    throw new IndexOutOfRangeException(string.Format("Index {0} is out of range!", colsIndex));
                }
                T result = this.theMatrix[this.rows, this.cols];
                return result;
            }

            set
            {
                this.theMatrix[rowsIndex, colsIndex] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new InvalidOperationException("Matrices must have same dimensions.");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix2.Cols);
            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = (dynamic)matrix1[row, col] + (dynamic)matrix2[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new ArgumentException("Matrices must have the same number of rows and the same number of columns");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix1.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = (dynamic)matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Cols || matrix1.Cols != matrix2.Rows)
            {
                throw new InvalidOperationException("Matrices must have propertional dimensions.");
            }

            Matrix<T> result = new Matrix<T>(matrix1.Rows, matrix2.Cols);
            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    for (int index = 0; index < matrix1.Cols; index++)
                    {
                        result[row, col] += (dynamic)matrix1[row, index] * matrix2[index, col];
                    }
                }
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < theMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < theMatrix.GetLength(1); j++)
                {
                    sb.Append(theMatrix[i, j] + " ");
                }
                if (i < theMatrix.GetLength(0) - 1)
                {
                    sb.Append("\n");
                }
            }
            return sb.ToString();
        }
    }
}