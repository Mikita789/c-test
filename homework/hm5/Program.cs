//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RandomIntArr(int count, int startInt, int finishInt)
{
    int[] result = new int[count];
    for ( int i = 0; i < count; i++)
    {
        result[i] = new Random().Next(startInt,finishInt);
    }
    return result;
}

void PrintArr<T>(ref T[] arr)
{
    Console.Write("Cгенерированный массив: ");
    foreach (T i in arr)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

//способ1 
// int[] arr = RandomIntArr(10,100,1000);

// int EvenNumbersCount (int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) { count += 1; }
//     }
//     return count;
// }
// PrintArr(ref arr);
// Console.WriteLine(EvenNumbersCount(arr));

//способ 2
// int[] arr = RandomIntArr(10, 100, 1000);
// PrintArr(ref arr);
// int[] filteredArr = arr.Where(i => i%2==0).ToArray();
// Console.WriteLine($"Число четных в массиве: {filteredArr.Length}");


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] testArr = RandomIntArr(10, 1, 100);
// PrintArr(ref testArr);
//способ 1
// for (int i = 1; i < testArr.Length; i += 2)
// {
//     Console.Write($"{testArr[i]} ");
// }
//способ 2
// for (int i = 0; i < testArr.Length; i++)
// {
//     if (i % 2 != 0) { Console.Write($"{testArr[i]} "); }
// }


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] RandomDoubleArr(int count, double startDouble, double finishDouble)
{
    double[] result = new double[count];
    for ( int i = 0; i < count; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * (finishDouble - startDouble) + startDouble, 2);
    }
    return result;
}
double[] arr = RandomDoubleArr(10, 10.0, 100.0);
PrintArr(ref arr);
//способ 1
//Console.WriteLine($"максимальный элемент = {arr.Max()}, минимальный элемент = {arr.Min()}, макс - мин = {arr.Max() - arr.Min()}");

//способ 2
// Array.Sort(arr);
// Console.WriteLine($"максимальный элемент = {arr[^1]}, минимальный элемент = {arr[0]}, макс - мин = {arr[^1] - arr[0]}");

//способ 3
// double max = arr[0];
// double min = arr[0];
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > max)
//     {
//         max = arr[i];
//     }
//     if (arr[i] < min)
//     {
//         min = arr[i];
//     }
// }
// Console.WriteLine($"max = {max}, min = {min}.   {max - min}");


