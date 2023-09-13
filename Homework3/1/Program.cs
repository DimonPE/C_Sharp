// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Vozvedenie (string message, string message2)
{
    Console.WriteLine($"Введите число {message}, которое будите возводить.");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите число {message2}, которое будет возводить число {message} в степень этого числа");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int num3 = 1;
    int i = 0;
        if (num2<0){
        Console.WriteLine("Введите натуральную степень!");
        }else{
             while (i<num2){
             num3 = num3 * num1;
             i++;
                           }
        Console.WriteLine($"Ваше число {num3}.");
        }
    return num3;
}
int x = Vozvedenie("A","B");