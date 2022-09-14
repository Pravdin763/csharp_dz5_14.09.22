using System;
using System.Linq;
using System.Text;
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите колличество элементов массива: ");
int numbers = int.Parse(Console.ReadLine()!);
int[] array = new int[numbers];
Console.WriteLine("Введите минимальное число массива: ");
int minNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное число массива: ");
int maxNumber = int.Parse(Console.ReadLine()!);

int[] Filling(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}
void writeArray(int[] arr)
{
    Console.WriteLine($"Массив: {string.Join(", ", arr)}");
}
int writeNumInArray(int[] arr)
{
    Console.WriteLine("Элементы массива array на нечетных позициях: ");
    int count = 0;
    for (int i = 1; i < numbers; i += 2)
    {
        count += array[i];
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return count;
}
void WriteCount(int x)
{
    Console.WriteLine($"Сумма элементов на нечетных позициях массива array: {x}");
}

Filling(array, minNumber, maxNumber);
writeArray(array);
int count = writeNumInArray(array);
WriteCount(count);
