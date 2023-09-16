// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

 double [] GenerateArray(int length, int max){
    double [] array = new double [length];
    for (int i=0; i<array.Length; i++){
        array[i] = new Random().NextDouble()*max;
        array[i] = Math.Round(array[i], 2);
    }
    return array;
 }
 double Difference(double [] array){
    double max = array[0];
    double min = array[0];
    double difference = 0;
    for (int i=0; i<array.Length; i++){
        if (max<array[i]){
            max = array[i];
        }
        if (min>array[i]){
            min = array[i];
        }
        difference = max - min;
    }
    return difference;
 }
double [] array = GenerateArray(5, 10);
double difference = Difference(array);
Console.WriteLine("Массив:");
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Разность между максимальным и минимальным значениями массива равно: {difference}");
