// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int [, ] GenerateMatrix(int num, int num2, int min, int max)
{
    int[, ] matrix = new int [num, num2];
    Random rand = new Random();
    for (int i = 0; i<num; i++)
    {
        for (int j = 0; j<num2; j++)
        {
            matrix[i,j] = rand.Next(min, max+1);
        }
    }
    return matrix;
}
void PrintMatrix(int [,] matrix)
{
 for (int i = 0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j<matrix.GetLength(1); j++)
        {
           Console.Write($"{matrix[i,j]}\t");
        }
   Console.WriteLine();
    }
}
void ChangeMatrix(int[,] matrix)
{
int temp = 0;

for (int i = 0; i < matrix.GetLength(1); i++)
{
temp = matrix[matrix.GetLength(0) -1, i];
matrix[matrix.GetLength(0) -1, i] = matrix[0, i];
matrix[0, i] = temp;
}
}

int[,] matrix = GenerateMatrix(3, 4, -4, 10);
PrintMatrix(matrix);
ChangeMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);