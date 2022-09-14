// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите колличество элементов массива: ");
int numbers = int.Parse(Console.ReadLine()!);
double[] array = new double[numbers];


double[] Filling(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите вещественное число массива array {i + 1} из {arr.Length}");
        arr[i] = double.Parse(Console.ReadLine()!);
    }
    return arr;
}

void WriteArray(double[] arr)
{
    Console.WriteLine($"Массив: {string.Join(", ", arr)}");
}

double Min(double[] arr)
{
    double minNum = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNum)
        {
            minNum = arr[i];
        }
    }
    Console.WriteLine($"Минимальное = {minNum}");
    return minNum;
}

double Max(double[] arr)
{
    double maxNum = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNum)
        {
            maxNum = arr[i];
        }
    }
    Console.WriteLine($"Максимальное = {maxNum}");
    return maxNum;
}

void PrintDifference(double min, double max)
{
    Console.WriteLine($"Разница между минимальным и максимальным элементом массива array = {max - Math.Abs(min)}");
}


Filling(array);
WriteArray(array);
double minNum = Min(array);
double maxNum = Max(array);
PrintDifference(minNum, maxNum);


