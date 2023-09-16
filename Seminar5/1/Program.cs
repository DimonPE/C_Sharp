// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int [] GenerateArray(int length, int min, int max){
    int[] array = new int [length];
    for (int i=0; i<array.Length; i++){
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}
int SumMin(int [] array){
    int summin = 0;
    for (int i=0; i<array.Length; i++){
        if (array[i]<0){
            summin = summin + array[i];
        }
    }
    return summin;
}

int SumMax(int [] array){
    int summax = 0;
    for (int i=0; i<array.Length; i++){
        if (array[i]>0){
            summax = summax + array[i];
        }
    }
    return summax;
}
int [] array = GenerateArray(12, -9, 9);
int min = SumMin(array);
int max = SumMax(array);
string str = string.Join(", ", array);
Console.WriteLine(str);
Console.WriteLine($"Сумма положительных чисел: {max}");
Console.WriteLine($"Сумма отрицательных чисел: {min}");