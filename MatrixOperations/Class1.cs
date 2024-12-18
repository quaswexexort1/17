namespace MatrixOperations
{
    public static class MatrixHelper
    {
        public static void SwapMinMax(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0) return; 

            int minVal = matrix[0, 0];
            int maxVal = matrix[0, 0];
            int minRow = 0;
            int minCol = 0;
            int maxRow = 0;
            int maxCol = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < minVal)
                    {
                        minVal = matrix[i, j];
                        minRow = i;
                        minCol = j;
                    }
                    if (matrix[i, j] > maxVal)
                    {
                        maxVal = matrix[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            int temp = matrix[minRow, minCol];
            matrix[minRow, minCol] = matrix[maxRow, maxCol];
            matrix[maxRow, maxCol] = temp;
        }
    }
}

