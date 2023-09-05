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
    if (num1 >=100 && num1 < 999){
       int num2 = num1;
       num2 = num2%10;
      Console.WriteLine("Третья цифра вашего числа: "+num2);
    }
    if (num1>999 && num1<10000){
      int num2 = num1/10;
      num2 = num2%10;
      Console.WriteLine("Третья цифра вашего числа: "+num2);
    } 
    if (num1>9999 && num1<100000){
      int num2 = num1/100;
      num2 = num2%10;
      Console.WriteLine("Третья цифра вашего числа: "+num2);
      }
      if (num1>99999 && num1<1000000){
      int num2 = num1/1000;
      num2 = num2%10;
      Console.WriteLine("Третья цифра вашего числа: "+num2);
      }
      if (num1>999999 && num1<10000000){
      int num2 = num1/10000;
      num2 = num2%10;
      Console.WriteLine("Третья цифра вашего числа: "+num2);
      }
      if (num1>9999999 && num1<100000000){
      int num2 = num1/100000;
      num2 = num2%10;
      Console.WriteLine("Третья цифра вашего числа: "+num2);
      }
    }