// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите колличество элементов массива: ");
int numbers = int.Parse(Console.ReadLine()!);
double[] array = new double[numbers];

for (int i=0; i<array.Length; i++)
{
    Console.WriteLine($"Введите вещественных число массива array {i+1} из {array.Length}");
    array[i] = double.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Массив: {string.Join(", ", array)}");

double minNum = array[0];

for (int i=0; i<array.Length; i++)
{
    if (array[i]< minNum)
    {
        minNum = array[i];
    }
}

Console.WriteLine(minNum);
double maxNum = array[0];

for (int i=0; i<array.Length; i++)
{
    if (array[i]> maxNum)
    {
        maxNum = array[i];
    }
}

Console.WriteLine(maxNum);
Console.WriteLine($"Разница между минимальным и максимальным элементом массива array = {maxNum-Math.Abs(minNum)}");