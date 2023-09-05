// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 > 99 && num1 < 1000){
    int num2 = num1%100;
    int num3 = num2/10;
Console.WriteLine("Заданное число: "+(num1));
Console.WriteLine("Вторая цифра этого числа: "+(num3));
}
else{
    Console.WriteLine("Это не трёхзначное число!");
}