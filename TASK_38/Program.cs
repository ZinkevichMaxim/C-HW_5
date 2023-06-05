Console.Clear();

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// double[] GetArray(int len)
// {
//     double [] arr = new double[len];
//     for(int i = 0; i < len; i++)
//     {
//         arr[i] = new Random().NextDouble();
//     }
//     return arr;
// }

// void PrintArray(double[] aarr)
// {
//     for(int i = 0; i < aarr.Length; i++)
//     {
//         Console.Write($"{aarr[i]}, ");
//     }
// }

// double[] array = GetArray(10);
// PrintArray(array);
// Console.WriteLine();

//___________________________________________________________________________________________________________________________________________________________________________________


// double[] GetArray(int len, int minValue, int maxValue)
// {
//     double [] arr = new double[len];
//     for(int i = 0; i < len; i++)
//     {
//         arr[i] = Convert.ToDouble(new Random().Next(minValue, maxValue)) / 100;
//     }
//     return arr;
// }

// void PrintArray(double[] aarr)
// {
//     for(int i = 0; i < aarr.Length; i++)
//     {
//         Console.Write($"{aarr[i]}, ");
//     }
// }

//____________________________________________________________________________________________________________________________________________________________________________________

void FindMinMax(double[] arrr)
{
    double min = arrr[0];
    double max = arrr[0];
    for(int i = 0; i < arrr.Length; i++)
    {
        if(min > arrr[i])
        {
            min = arrr[i];
        }
        if (max < arrr[i])
        {
            max = arrr[i];
        }
    }
        Console.Write($"Минимальный элемент в цикле = {min}. Максимальный элемент в цикле = {max}. Разниуа между максимальным и минимальным элементами сотавляет {max - min}");
    
}

double[] array = GetArray(10, 245, 2015);
PrintArray(array);
Console.WriteLine();
FindMinMax(array);
Console.WriteLine();
