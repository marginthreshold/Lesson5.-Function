using static System.Console;
Clear();

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

WriteLine("Введите количество элементов массива: ");
int length = int.Parse(ReadLine()!);
WriteLine("Введите минимальный элемент разброса массива: ");
int min = int.Parse(ReadLine()!);
WriteLine("Введите максимальный элемент разброса массива: ");
int max = int.Parse(ReadLine()!);

int[] newArray = SetArray(length, min, max);
Array.ForEach(newArray,el=> Write(" "+el));

WriteLine();
WriteLine($"Количество четных элементов в массиве равно: {CountEvenInArray(newArray)}");


int CountEvenInArray(int[] array)
{
    int evensum = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
            evensum += 1;
    }
    return evensum;
}


int[] SetArray(int size, int minRnd, int maxRnd)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minRnd, maxRnd);
    }

    return array;
}
