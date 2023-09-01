// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num3 = 0;
int num2 = num1 / 2;
Console.WriteLine("Чётные числа: ");
while (num2 >= 1){
    num3 = num3 + 2;
    num2 = num2 - 1;
    Console.WriteLine(num3);
}
if (num1 <= 1){
    Console.WriteLine("Четных чисел нет");
}