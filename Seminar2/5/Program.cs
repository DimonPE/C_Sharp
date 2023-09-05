// 16. Напишите программу, которая принимает на 
// вход два числа и проверяет, является ли одно 
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число для проверки:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для проверки:");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 * num2 == num){
    Console.WriteLine("Является.");
}
else {
   if (num * num == num2){
    Console.WriteLine("Является.");
}else{
    Console.WriteLine("Не является.");
}
}
