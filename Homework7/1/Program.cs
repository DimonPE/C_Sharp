// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [, ] GenerateMatrix(int n, int min, int max)
{
    int[, ] matrix = new int [n, n];
    Random rand = new Random();
    for (int i = 0; i<n; i++)
    {
        for (int j = 0; j<n; j++)
        {
            matrix[i,j] = rand.Next(min, max+1);
        }
    }
    return matrix;
}
void PrintMatrix(int [,] matrix, string message)
{
    Console.WriteLine($"{message}");
 for (int i = 0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j<matrix.GetLength(1); j++)
        {
           Console.Write($"{matrix[i,j]}\t");
        }
   Console.WriteLine();
    }
} 
void ChangeMatrix(int [,] matrix)
{
    int temp = 0;
     for (int i = 0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j<matrix.GetLength(1)-1; j++)
        {
           if (matrix[i,j+1]>matrix[i, j])
           {
               temp = matrix[i, j+1];
               matrix[i, j+1] = matrix[i, j];
               matrix[i, j] = temp;
           } 
        }
    }
}
Console.Clear();
int [,] matrix = GenerateMatrix(3, 0, 10);
PrintMatrix(matrix, "Первый массив:");
ChangeMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix, "Изменённый массив:");