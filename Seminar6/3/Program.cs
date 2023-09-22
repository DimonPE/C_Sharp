// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Напишите число: ");
int num = int.Parse(Console.ReadLine()!);
int [] ToBin(int num){
    int n = 0;
    int num1 = num;
      while (num1>0){
        num1 = num1/2;
        n++;
    }
    int [] array = new int[n];
    for (int i = 0; i<n; i++){
        array[n-1-i] = num%2;
        num = num/2;
    }
    return array;
}
int [] array = ToBin(num);
Console.WriteLine($"[{string.Join(" ", array)}]");