using static System.Console;

Clear();

// Дополнительная задача. Найти самую длинную последовательность в массиве из одинкаовых чисел. Число задаем с клавиатуры.



WriteLine("Введите количество элементов массива: ");
int length = int.Parse(ReadLine()!);

WriteLine("Введите число,у которого нужно найти максимальное количество повторений подряд: ");
int number = int.Parse(ReadLine()!);


int[] newArray = SetArray(length, 0, 2);
Array.ForEach(newArray, el => Write(" " + el));

WriteLine();
WriteLine($"Максимальная последовательность равна: {LongestRepetingElementsInArray(newArray,number)}");




int LongestRepetingElementsInArray(int[] array, int numberofLongest)
{
    int longest=0;
    int newlongest=0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]==numberofLongest)
        {
        longest=Math.Max(newlongest,longest);
        newlongest = array[i] == array[i - 1] ? newlongest+1:0;
        }
    }    

    return longest+1;
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
