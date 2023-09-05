// Генерируется случайное число от 10 до 99 и показывает наибольшую его цифру.

Random rand = new Random();
int num = rand.Next(10,100);
int num1 = num / 10;
int num2 = num % 10;
if (num1 > num2){
    Console.Write("Выпало число: " + (num) + " и большая его цифра: " + (num1));
}
else{
    Console.Write("Выпало число: " + (num) + " и большая его цифра: " + (num2));
}