using System;
using System.Linq.Expressions;

namespace OopPartTwo.Resources
{
    public class Matrix<T>
        where T : struct, IEquatable<T>, IComparable<T>
    {
        private readonly int rowSpan;
        private readonly int colSpan;
        private T[,] matrix;

        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || col < 0 || row >= this.matrix.GetLength(0) || col >= this.matrix.GetLength(1))
                {
                    throw new ArgumentOutOfRangeException("row and col must be in the range of the Matrix!");
                }
                return matrix[row, col];
            }
            set
            {
                if (row < 0 || col < 0 || row >= this.matrix.GetLength(0) || col >= this.matrix.GetLength(1))
                {
                    throw new ArgumentOutOfRangeException("Matrix out of range!");
                }
                matrix[row, col] = value;

            }
        }
        public int RowSpan
        {
            get
            {
                return this.rowSpan;
            }
        }
        public int ColSpan
        {
            get
            {
                return this.colSpan;
            }
        }

        public Matrix(int rowSpan, int colSpan)
        {
            this.rowSpan = rowSpan;
            this.colSpan = colSpan;
            this.matrix = new T[rowSpan, colSpan];
        }
        public static Matrix<T> matrixAGenerator()
        {
            Matrix<T> result = new Matrix<T>(5, 5);
            int cnt = 0;
            for (int i = 0; i < result.RowSpan; i++)
            {
                for (int j = 0; j < result.ColSpan; j++)
                {
                    result[i, j] = (dynamic)cnt;
                    cnt++;
                }

            }
            return result;
        }
        public static Matrix<T> matrixBGenerator()
        {
            Matrix<T> result = new Matrix<T>(5, 5);
            int cnt = 24;
            for (int i = 0; i < result.RowSpan; i++)
            {
                for (int j = 0; j < result.ColSpan; j++)
                {
                    result[i, j] = (dynamic)cnt;
                    cnt--;
                }

            }
            return result;
        }
        public static Matrix<T> operator +(Matrix<T> matrixA, Matrix<T> matrixB)
        {
            if (matrixA.RowSpan != matrixB.RowSpan || matrixA.ColSpan != matrixB.ColSpan)
            {
                throw new InvalidOperationException($"Matrices have different rows and/or cols!");
            }

            Matrix<T> result = new Matrix<T>(matrixA.RowSpan, matrixB.ColSpan);
            try
            {
                for (int i = 0; i < matrixA.RowSpan; i++)
                {
                    for (int j = 0; j < matrixA.ColSpan; j++)
                    {
                        result[i, j] = (dynamic)matrixA[i, j] + (dynamic)matrixB[i, j] + (dynamic)0.5;
                    }

                }
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException($"dynamic misfired :)");
            }
            return result;
        }
        public static Matrix<T> operator -(Matrix<T> matrixA, Matrix<T> matrixB)
        {
            if (matrixA.RowSpan != matrixB.RowSpan || matrixA.ColSpan != matrixB.ColSpan)
            {
                throw new InvalidOperationException($"Matrices have different rows and/or cols!");
            }

            Matrix<T> result = new Matrix<T>(matrixA.RowSpan, matrixB.ColSpan);
            try
            {
                for (int i = 0; i < matrixA.RowSpan; i++)
                {
                    for (int j = 0; j < matrixA.ColSpan; j++)
                    {
                        result[i, j] = (dynamic)matrixA[i, j] - (dynamic)matrixB[i, j] + (dynamic)0.5;
                    }

                }
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException($"dynamic misfired :)");
            }
            return result;
        }
        public static Matrix<T> operator *(Matrix<T> matrixA, Matrix<T> matrixB)
        {
            if (matrixA.RowSpan != matrixB.RowSpan || matrixA.ColSpan != matrixB.ColSpan)
            {
                throw new InvalidOperationException($"Matrices have different rows and/or cols!");
            }

            Matrix<T> result = new Matrix<T>(matrixA.RowSpan, matrixB.ColSpan);
            try
            {
                for (int i = 0; i < matrixA.RowSpan; i++)
                {
                    for (int j = 0; j < matrixA.ColSpan; j++)
                    {
                        result[i, j] = (dynamic)matrixA[i, j] * (dynamic)matrixB[i, j] + (dynamic)0.5;
                    }

                }
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException($"dynamic misfired :)");
            }
            return result;
        }
        public static bool operator true(Matrix<T> matrixComp)
        {
            if (matrixComp.RowSpan == matrixComp.ColSpan)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator false(Matrix<T> matrixComp)
        {
            if (matrixComp.RowSpan > matrixComp.ColSpan || matrixComp.RowSpan < matrixComp.ColSpan)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string entity = "";
            for (int i = 0; i < this.rowSpan; i++)
            {
                for (int j = 0; j < this.colSpan; j++)
                {
                    entity += Convert.ToString(matrix[i, j]) + " ";
                }
                entity += "\n";
            }
            return entity;
        }
    }
}





