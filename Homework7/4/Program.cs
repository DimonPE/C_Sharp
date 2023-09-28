// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int [, ] GenerateMatrix(int min, int max)
{
    int[, ] matrix = new int [4, 4];
    Random rand = new Random();
    int x = rand.Next(min,max+1);
    matrix[0,0] = x;
        for (int j = 1; j<4; j++)
        {
            matrix[0, j] = matrix[0, j-1] +1;
        }
        for (int i = 1; i<4; i++)
        {
            matrix[i, 3] = i+matrix[0,3];
        }
        int m = 3;
        for (int j = 0; j<3; j++)
        {
            matrix[3, j] = matrix[3,3] + m; 
            m--;
        }
        matrix[2,0] = matrix[3,0] + 1;
        matrix[1,0] = matrix[2,0] + 1;
        matrix[1,1] = matrix[1,0] + 1;
        matrix[1,2] = matrix[1,1] + 1;
        matrix[2,2] = matrix[1,2] + 1;
        matrix[2,1] = matrix[2,2] + 1;
    return matrix;
}

void PrintMatrix(int [,] matrix, string message)
{
    Console.Clear();
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
int [,] matrix = GenerateMatrix(0, 10);
PrintMatrix(matrix, "Спиральный массив:");