Console.Clear();

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int len, int minValue, int maxValue)
{
    int [] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void PrintArray(int[] arrr)
{
    for(int i = 0; i < arrr.Length; i++)
    {
        Console.Write($"{arrr[i]}, ");
    }
}


void sumOddIndex(int[] aarr)
{
    int sumOdInDig = 0;
    for(int i = 1; i < aarr.Length; i = i + 2)
    {
        sumOdInDig = sumOdInDig + aarr[i];
    }
    Console.Write($"Сумма элементов, стоящих на нечетных позициях = {sumOdInDig}");
}

int[] array = GetArray(4, 3, 23);
PrintArray(array);
Console.WriteLine();
sumOddIndex(array);
Console.WriteLine();


