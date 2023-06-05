Console.Clear();

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int len, int minValue, int maxValue)
{
        int[] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void PrintArrey(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

void EvenNumbers(int[] arrr)
{
    int count = 0;
    
    for(int i = 0; i < arrr.Length; i++)
    {
        int temp = arrr[i] % 2;
        if (temp != 0)
        {
            count = count;
        }
        else
        {
            count++;
        }
    }
    Console.Write($"Колличество четных чисел в Вашем массиве = {count}");
}

int[] arrey = GetArray(10, 100, 999);
PrintArrey(arrey);
Console.WriteLine();
EvenNumbers(arrey);
Console.WriteLine();
