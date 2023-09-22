// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] getRandomArray(int length, int min, int max)
{
int[] array = new int[length];

for(int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(min, max + 1);
}
return array;
}

void Change(int [] array){
    int temp = 0;
    for (int i = 0; i<array.Length/2; i++){
        temp = array[i];
        array[i] = array[array.Length-i-1];
        array[array.Length-i-1] = temp;
    }
}
int [] array = getRandomArray(5, -2, 10);
Console.WriteLine($"Ваш массив: [{string.Join(" ", array)}]");
Change(array);
Console.WriteLine($"Измененный массив: [{string.Join(" ", array)}]");