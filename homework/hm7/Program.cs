void PrintArr<T>(T[] arr)
{
    Console.Write("Cгенерированный массив: ");
    foreach (T i in arr)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}
int[,] CreateTwoDimensioalnArr(int str , int col)
{
    int[,] arr = new int[str, col];
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(10, 100);
        }
    }
    return arr;
}
int CheckNumberInt (string message)
{
    bool flag = true;
    int result = 0;

    while (flag)
    {
        Console.Write(message);
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            result = number;
            Console.WriteLine($"Вы ввели {result}");
            flag = false;
        }
        else {Console.WriteLine($"Не удалось распознать число. Попробуйте снова.");}
    }
    return result;
}
void PrintArr2<T>(T[,] arr)
{
    Console.WriteLine("Cгенерированный массив: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}" + new string(' ', 8 - arr[i,j].ToString().Length));
        }
        Console.WriteLine();
    }
}
// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// int str = CheckNumberInt("Введите число строк    ");
// int columns = CheckNumberInt("Введите число столбцов    ");

// double[,] CreateTwoDimensioalnArrDouble(int str , int col)
// {
//     double[,] arr = new double[str, col];
//     for (int i = 0; i < str; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             arr[i, j] = Math.Round(new Random().Next(10, 100) + new Random().NextDouble(),2);
//         }
//     }
//     return arr;
// }
// double[,] arrDouble = CreateTwoDimensioalnArrDouble(str, columns);
// PrintArr2(arrDouble);


//Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//           и возвращает значение этого элемента или же указание, что такого элемента нет.

//если принимаем от пользователя порядковый номер строки и столбца:;

// int userStr = CheckNumberInt("Введите строку     ");
// int userCol = CheckNumberInt("Введите столбец     ");
// Random rand = new Random();
// int[,] arr = CreateTwoDimensioalnArr(rand.Next(3,10) , rand.Next(3,10));
// PrintArr2(arr);

// void PrintSelectedItem(int[,] array, int positionStr, int positionCol)
// {
//     if (array.GetLength(0) >= positionStr-1 && array.GetLength(1) >= positionCol-1)
//     {
//         Console.WriteLine($"Искомый элемент:  {array[positionStr-1, positionCol-1]}");
//     }
//     else {Console.WriteLine("Элемента не обнаружено");}
// }
// PrintSelectedItem(arr, userStr, userCol);

//если принимаем от пользователя порядковый номер
// Random rand = new Random();
// int[,] arr = CreateTwoDimensioalnArr(rand.Next(3,10) , rand.Next(3,10));
// PrintArr2(arr);
// int number = CheckNumberInt("Введите порядковый номер элемента    ");

// void PrintSelectedItem2(int[,] array , int position)
// {
//     bool falg = true;
//     if (position <= array.GetLength(0)*array.GetLength(1))
//     {
//         int count = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (count == position-1) {Console.WriteLine($"искомый элемент {array[i,j]}");
//                                                                             falg = false;
//                                                                             break;}
//                 count++;
//             }
//             if (!falg) {break;}
//         }
//     }
//     else {Console.WriteLine("Элемент не найден");}
// }
// PrintSelectedItem2(arr, number);

//ниже на мой взгляд лучшая реализация, т.к. вычисляет сразу без перебора в цикле
// Random rand = new Random();
// int[,] arr = CreateTwoDimensioalnArr(rand.Next(3,10) , rand.Next(3,10));
// PrintArr2(arr);
// int number = CheckNumberInt("Введите порядковый номер элемента    ");

// void PrintSelectedItem3(int[,] array, int position)
// {
//     int strElement = position % arr.GetLength(1) == 0 ? position/arr.GetLength(1) -1 : position/arr.GetLength(1) ;
//     int colElement = position - (strElement) * arr.GetLength(1) - 1;
//     Console.WriteLine(arr[strElement, colElement]);
// }
// PrintSelectedItem3(arr, number);


//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] arr = CreateTwoDimensioalnArr(5,3);
// PrintArr2(arr);
// double[] MeanOfColumns(int[,] array)
// {
//     double[] res = new double[array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             sum += array[j,i];
//         }
//         res[i] = Convert.ToDouble(sum) / Convert.ToDouble(array.GetLength(0));
//         sum = 0;
//     }
//     return res;
// }

// double[] result = MeanOfColumns(arr);
// Console.WriteLine("Средние велечина по столбцам    ");
// PrintArr(result);




