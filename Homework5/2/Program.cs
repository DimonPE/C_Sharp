// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

 int [] GenerateArray(int length, int min, int max){
    int[] array = new int [length];
    for (int i=0; i<array.Length; i++){
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}
int SumArray(int [] array){
    int sum = 0;
    for (int i=0; i<array.Length; i=i+2){
        sum += array[i];
    }
    return sum;
}
int [] array = GenerateArray(5, 0, 50);
int sum = SumArray(array);
Console.WriteLine("Массив:");
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Сумма: {sum}");
