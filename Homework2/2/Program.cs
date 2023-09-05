// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 < 99){
  Console.WriteLine("Третьей цифры нет!");
}
  else {
int num2 = num1/10;
int num3 = num2%10;
Console.WriteLine("Третья цифра вашего числа: " + num3);
  }