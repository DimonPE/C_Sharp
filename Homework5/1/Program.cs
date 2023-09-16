// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] GenerateArray(int length, int min, int max){
    int[] array = new int [length];
    for (int i=0; i<array.Length; i++){
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}
int Double(int [] array){
    int count = 0;
    for (int i=0; i<array.Length; i++){
        if (array[i]%2==0){
         count++;
        }
    }
    return count;
}
int [] array = GenerateArray(5, 100, 999);
int count = Double(array);
Console.WriteLine("Массив:");
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Четных чисел: {count}");