using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labitint
{
    public class GameMatrix
    {
        private readonly int rows;
        private readonly int columns;
        private readonly GameObject[,] matrix;

        public GameMatrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new GameObject[rows, columns];
        }

        public void AddObject(GameObject gameObject, int row, int column)
        {
            if (row >= 0 && row < rows && column >= 0 && column < columns)
            {
                matrix[row, column] = gameObject;
            }
        }

        public GameObject GetObject(int row, int column)
        {
            if (row >= 0 && row < rows && column >= 0 && column < columns)
            {
                return matrix[row, column];
            }
            return null;
        }

        public void RemoveObject(int row, int column)
        {
            if (row >= 0 && row < rows && column >= 0 && column < columns)
            {
                matrix[row, column] = null;
            }
        }

        public void MoveObject(int oldRow, int oldColumn, int newRow, int newColumn)
        {
            if (oldRow >= 0 && oldRow < rows && oldColumn >= 0 && oldColumn < columns &&
                newRow >= 0 && newRow < rows && newColumn >= 0 && newColumn < columns)
            {
                matrix[newRow, newColumn] = matrix[oldRow, oldColumn];
                matrix[oldRow, oldColumn] = null;
            }
        }
    }
}

