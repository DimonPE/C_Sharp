// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [, ] GenerateMatrix(int m, int n, int min, int max)
{   
   
    int[, ] matrix = new int [m, n];
    Random rand = new Random();
    for (int i = 0; i<m; i++)
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
int [] SumInMatrix(int [,] matrix)
{
    int [] array = new int [matrix.GetLength(0)];
    for (int i = 0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j<matrix.GetLength(1); j++)
        {
          array[i] = array[i] + matrix[i,j];
        }
    }
    return array;
}
void Checker(int [] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i]<min)
        {
            min = array[i];
            index = i;
        }
    }
    index++;
    Console.WriteLine($"Сумма каждого элемента строки: [{string.Join(", ", array)}]");
    Console.WriteLine($"Наименьшая сумма элементов находится в {index} строке.");

}
Console.Clear();
int [,] matrix = GenerateMatrix(3, 5, 0, 10);
PrintMatrix(matrix, "Прямоугольная матрица:");
int [] array = SumInMatrix(matrix);
Checker(array);