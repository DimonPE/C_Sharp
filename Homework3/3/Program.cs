// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void GenerateArray(int [] massiv){
    int i = 0;
    int n=massiv.Length;
    while (i<n){
        massiv[i] = new Random().Next(1,10);
        i++;
    }
}
void FillArray(int [] massiv){
    int i=0;
    int n = massiv.Length;
    while (i<n){
       Console.Write(massiv[i]+" ");
       i++;
    }
}
Console.WriteLine("Введите количество символов в массиве: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваш массив: ");
int [] mak = new int[count];
GenerateArray(mak);
FillArray(mak);