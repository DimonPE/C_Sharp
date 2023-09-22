// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.


Console.Write("Напишите числа k1, b1, k2, b2 через пробел: ");
double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();

double x = (array[3] +array[1])/(array[0]*-1.0 + array[2]);
double y = array[2] * x + array[3];

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}; Y: {y}");