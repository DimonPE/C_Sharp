﻿// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Напишите три числа через пробел: ");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
// Console.WriteLine(string.Join(" ", str));
if (array[0] > array[1] + array[2]){
    Console.WriteLine("Такого треугольника не существует.");
} else {
    if (array[1] > array[0] + array[2]){
    Console.WriteLine("Такого треугольника не существует.");
}
else{
    if (array[2] > array[0] + array[1]){
    Console.WriteLine("Такого треугольника не существует.");
}
else{
    Console.WriteLine("Такой треугольник существует.");
}
}
}
