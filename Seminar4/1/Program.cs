//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36
int GetNumber(string message)
{
    Console.WriteLine($"Введите число {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int GetSum(int num)
{
    int sum = 0;
    for (int i=1; i<=num; i++)
    {
     sum += i;
     // sum = sum + i;
    }
    return sum;
}
int numA = GetNumber("A");
int sum = GetSum(numA);
Console.WriteLine($"sum = {sum}");
// int num2 = 5;
// int num3 = num2++;
// Console.WriteLine($"num2 = {num2} num3 = {num3}");