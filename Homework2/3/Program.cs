// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 > 0 && num1 <=7){
  if (num1>=1 && num1<6){
    Console.WriteLine("Сегодня поработаем!");
  }
  else{
    Console.WriteLine("Отдыхаем!");
  }
}
else{
    Console.WriteLine("Это не день недели!");
}