// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int Number(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{Number(n, m + 1)}, ");
  return m;
}

int n = Prompt("Введите число: ");
if (n < 1)
{
  Console.WriteLine("Введите положительное число!");
  return;
}
Console.WriteLine(Number(n, 1));