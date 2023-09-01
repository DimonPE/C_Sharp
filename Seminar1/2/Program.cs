// Проверка является ли 1 число квадратом 2
Console.WriteLine("Введите число для проверки:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для проверки:");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 * num2 == num){
    Console.WriteLine("Является.");
}
else {
   Console.WriteLine("Не является.");
}

