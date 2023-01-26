void PrintArr<T>(T[] arr)
{
    Console.Write("Cгенерированный массив: ");
    foreach (T i in arr)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

int[,] CreateTwoDimensioalnArr(int str, int col, int startInt, int finishInt)// создание двумерного массива
{
    int[,] arr = new int[str, col];
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(startInt, finishInt + 1);
        }
    }
    return arr;
}

int CheckNumberInt(string message) // ввод числа пользователем
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
        else { Console.WriteLine($"Не удалось распознать число. Попробуйте снова."); }
    }
    return result;
}

void PrintArr2<T>(T[,] arr) //принт двумерный массив
{
    Console.WriteLine("массив: ");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}" + new string(' ', 6 - arr[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
}

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
//строки двумерного массива.
// int strinCount = 4;
// int columnsCount = 4;
// int startNumber = 10;
// int finishNumber = 50;

// int[,] arr = CreateTwoDimensioalnArr(strinCount, columnsCount,startNumber, finishNumber);
// PrintArr2(arr);

// void SortNumbersInArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// SortNumbersInArray(arr);
// PrintArr2(arr);

//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int strinCount = 5;
// int columnsCount = 4;
// int startNumber = 1;
// int finishNumber = 9;

// int[,] arr = CreateTwoDimensioalnArr(strinCount, columnsCount,startNumber, finishNumber);
// PrintArr2(arr);

// int StringMaxSumNumbers (int[,] array)
// {
//     int minSum = finishNumber * 4;
//     int numberResString = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sumStr = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sumStr += array[i,j];
//         }
//         Console.WriteLine($"string {i+1} - sum = {sumStr}");
//         if (sumStr < minSum)
//         {
//             minSum = sumStr;
//             numberResString = i;
//         }
//     }
//     Console.WriteLine($"min sum in string {numberResString + 1}");
//     return numberResString + 1;
// }

// StringMaxSumNumbers(arr);


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// int strinCount1 = 2;
// int columnsCount1 = 2;
// int startNumber = 1;
// int finishNumber = 9;
// int[,] arr1 = CreateTwoDimensioalnArr(strinCount1, columnsCount1, startNumber, finishNumber);
// Console.WriteLine("----------arr1----------");
// PrintArr2(arr1);

// int strinCount2 = 2;
// int columnsCount2 = 2;
// int[,] arr2 = CreateTwoDimensioalnArr(strinCount2, columnsCount2, startNumber, finishNumber);
// Console.WriteLine("----------arr2----------");
// PrintArr2(arr2);

// int[,] MultiplicationArray(int[,] array1, int[,] array2)
// {
//     int[,] resultMatrix = new int[array1.GetLength(0), array2.GetLength(1)];
//     if (arr1.GetLength(0) != array2.GetLength(1))
//     {
//         Console.WriteLine("невозможно перемножить матрицы. Число строк первой должно совпадать в числом столбцов второй");
//         return resultMatrix;
//     }
//     else
//     {
//         for (int i = 0; i < resultMatrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < resultMatrix.GetLength(1); j++)
//             {
//                 int sum = 0;
//                 for (int k = 0; k < array1.GetLength(1); k++)
//                 {
//                     sum += array1[i,k] * array2[k,j];
//                 }
//                 resultMatrix[i,j] = sum;
//             }
//         }
//     }
//     return resultMatrix;
// }

// int[,] resArr = MultiplicationArray(arr1, arr2);
// Console.WriteLine("----------result----------");
// PrintArr2(resArr);


// Задача 62: Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int n = 4;
// string[,] sqareMatrix = new string[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//   sqareMatrix[i, j] = temp.ToString().Length < 2 ? $"0{temp.ToString()}" : temp.ToString();
//   temp++;
//   if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// PrintArr2(sqareMatrix);

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//создадим массив чисел для трехмерного массива
int x = 2;
int y = 2;
int k = 2;
Random rand = new Random();

int[] numbers = new int[x * y * k];
int count = 0;
while (numbers.Distinct().ToArray().Length < numbers.Length)
{
    int temp = rand.Next(10,100);
    if (!numbers.Contains(temp))
    {
        numbers[count] = temp; 
        count++;
    }
}
//заполняем последнее значение равное 0
int temp2 = rand.Next(10,100);
while (numbers.Contains(temp2))
{
    temp2 = rand.Next(10,100);
}
numbers[^1] = temp2;
PrintArr(numbers);

int[,,] arr = new int[x, y, k];
int position = 0;
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        for (int c = 0; c < k; c++)
        {
            arr[i,j,c] = numbers[position];
            Console.Write($"{arr[i,j,c]} index = ({i},{j},{c})  ");
            position++;
        }
        Console.WriteLine();
    }
}




