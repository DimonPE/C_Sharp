// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int index = 1;
int i = 0;
int sum = 0;
int num1 = num;
    while (num1>10){
    num1 /=10;
    index++;
    }
    for (i=0; i<index; i++){
        sum += num%10;
        num /=10;
    }
Console.WriteLine($"Сумма чисел {sum}");
    