using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Matrix<T> where T : struct
    {
        private int rows;
        private int cols;
        public T[,] matrix;

        public  Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = new T[rows, cols];
        }
        public T this[int row, int col]
        {
            get
            {
                validate(row, col);
                return matrix[row, col];
            }
            set
            {
                validate(row, col);
                matrix[row, col] = value;
            }
        }
        private void validate(int row, int col)
        {
            if (row < 0 || row >= rows || col < 0 || col >= cols)
            {
                throw new IndexOutOfRangeException();
            }
        }
        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if (!matrix[row, col].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if (!matrix[row, col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.rows != matrix2.rows || matrix1.cols != matrix2.cols)
            {
                throw new Exception("Wrong Dimensions!");
            }
            Matrix<T> matrix3 = new Matrix<T>(matrix1.rows, matrix1.cols);
            for (int row = 0; row < matrix3.rows; row++)
            {
                for (int col = 0; col < matrix3.cols; col++)
                {
                    matrix3[row, col] = (dynamic)matrix1[row, col] + matrix2[row, col];
                }
            }
            return matrix3;
        }
        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.rows != matrix2.rows || matrix1.cols != matrix2.cols)
            {
                throw new Exception("Wrong Dimensions!");
            }
            Matrix<T> matrix3 = new Matrix<T>(matrix1.rows, matrix1.cols);
            for (int row = 0; row < matrix3.rows; row++)
            {
                for (int col = 0; col < matrix3.cols; col++)
                {
                    matrix3[row, col] = (dynamic)matrix1[row, col] - matrix2[row, col];
                }
            }
            return matrix3;
        }
        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.cols != matrix2.rows)
            {
                throw new Exception("Wrong Dimensions!");
            }
            Matrix<T> matrix3 = new Matrix<T>(matrix1.rows, matrix2.cols);
            for (int row = 0; row < matrix3.rows; row++)
            {
                for (int col = 0; col < matrix3.cols; col++)
                {
                    for (int i = 0; i < matrix1.cols; i++)
                    {
                        matrix3[row, col] += (dynamic)matrix1[row, i] * matrix2[i, col];
                    }
                }
            }
            return matrix3;
        }
        public override string ToString()
        {
            StringBuilder matrixString = new StringBuilder();
            for (int row = 0; row < this.rows; row++)
            {
                for (int col = 0; col < this.cols; col++)
                {
                    string currentValue = string.Format("{0,4}", this.matrix[row, col]);
                    matrixString.Append(currentValue);
                }
                matrixString.AppendLine();
            }
            return matrixString.ToString();
        }
    }
}
