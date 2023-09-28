// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
int [, ] ChangeMatrix(int [, ] matrix)
{
    int[, ] matrix2 = new int [matrix.GetLength(1), matrix.GetLength(0)];
    if (matrix.GetLength(1) == matrix2.GetLength(1)){
        for (int i = 0; i<matrix.GetLength(1); i++)
    {
        for (int j = 0; j<matrix.GetLength(0); j++)
        {
            matrix2[i,j] = matrix[j,i];
        }
    }
    }else{
        Console.WriteLine("Матрицу невозможно перевернуть!");
    }
    return matrix2;
}
int [,] matrix = GenerateMatrix(PrintNum(), 0, 5);
PrintMatrix(matrix, "Первая матрица:");
Console.WriteLine();
int [,] matrix2 = ChangeMatrix(matrix);
PrintMatrix(matrix2, "Вторая матрица:");
int PrintNum()
{
    Console.Write("Введити размерность матрицы: ");
    int num2 = int.Parse(Console.ReadLine()!);
    return num2;
}

//  Правильное решение
// void Сhange(int[,] matrix)
// {
// if (matrix.GetLength(0) != matrix.GetLength(1))
// {
// Console.WriteLine("Не работает");
// return;
// }

// int rowElement = 0;
// int columnElement = 0;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = i; j < matrix.GetLength(1); j++)
// {
// rowElement = matrix[i, j];
// columnElement = matrix[j, i];

// matrix[i, j] = columnElement;
// matrix[j, i] = rowElement;
// }
// }
// }