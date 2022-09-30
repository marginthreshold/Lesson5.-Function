using static System.Console;

Clear();

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

WriteLine("Введите количество элементов массива: ");
int length = int.Parse(ReadLine()!);
WriteLine("Введите минимальный элемент разброса массива: ");
int min = int.Parse(ReadLine()!);
WriteLine("Введите максимальный элемент разброса массива: ");
int max = int.Parse(ReadLine()!);

int[] newArray = SetArray(length, min, max);
Array.ForEach(newArray, el => Write(" " + el));

WriteLine();
WriteLine($"Разность между {newArray.Max()} и {newArray.Min()} равна: {DiffBetweenMinAndMaxInArray(newArray)}");

int DiffBetweenMinAndMaxInArray(int[] array)
{
    int difference = array.Max() - array.Min();
    return difference;
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
