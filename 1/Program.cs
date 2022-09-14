using System;
using System.Linq;
using System.Text;
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите колличество элементов массива: ");
int numbers = int.Parse(Console.ReadLine()!);
int[] array = new int[numbers];

int[] Filling(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void writeArray(int[] arr)
{
    Console.WriteLine($"Массив: {string.Join(", ", arr)}");
}

int writeNumInArray(int[] arr)
{
    int count = 0;
    Console.WriteLine("Четные элементы массива: ");
    foreach (int number in array)
    {
        if (number % 2 == 0)
        {
            count += 1;
            Console.Write(number + " ");
        }
    }
    Console.WriteLine();
    return count;
}
void WriteCount(int x)
{
    Console.WriteLine($"Колличество четных элементов массива - {x}");
}

Filling(array);
writeArray(array);
int count = writeNumInArray(array);
WriteCount(count);