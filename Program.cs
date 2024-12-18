using MatrixOperations;
public class Program
{
    public static void Main(string[] args)
    {
        int[,] matrix =
        {
            {1, 5, 3},
            {4, 2, 6},
            {7, 9, 8}
        };

        Console.WriteLine("оригинальная матрица:");
        PrintMatrix(matrix); 

        MatrixHelper.SwapMinMax(matrix);

        Console.WriteLine("\nматрица после:");
        PrintMatrix(matrix); 

    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

