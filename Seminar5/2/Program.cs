// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
int [] GenerateArray(int length, int min, int max){
    int[] array = new int [length];
    for (int i=0; i<array.Length; i++){
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}

void ChangeZnak (int [] array){
    for (int i=0; i<array.Length; i++)
        {
            array[i] = array[i] *-1;
        };
    }
int [] array = GenerateArray(5, -9, 9);
Console.WriteLine("Изначальный массив:");
Console.WriteLine(string.Join(" ", array));
ChangeZnak(array);
Console.WriteLine("Измененный массив:");
Console.WriteLine(string.Join(" ", array));
