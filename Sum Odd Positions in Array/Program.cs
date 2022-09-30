using static System.Console;
Clear();

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

WriteLine("Введите количество элементов массива: ");
int length = int.Parse(ReadLine()!);
WriteLine("Введите минимальный элемент разброса массива: ");
int min = int.Parse(ReadLine()!);
WriteLine("Введите максимальный элемент разброса массива: ");
int max = int.Parse(ReadLine()!);

int[] newArray = SetArray(length, min, max);
Array.ForEach(newArray, el => Write(" " + el));

WriteLine();
WriteLine($"Сумма нечетных позиций элементов массива равна: {SumOddPositionsInArray(newArray)} ");


int SumOddPositionsInArray(int[] array)
{
    int sumOddIndex = 0;
    for (int i = 1; i < array.Length; i = i + 2)
        sumOddIndex = sumOddIndex + array[i];

    return sumOddIndex;
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