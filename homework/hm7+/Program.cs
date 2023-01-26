void PrintArr<T>(T[] arr) // принт одномерный массив 
{
    Console.Write("массив: ");
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


//2. Формируется и выводится прямоугольный массив (5 строк и 6 столбцов)
//целых случайных чисел от -40 до 40. Вычисляется и выводится: а) сумма
//чисел в каждой строке; б) среднее арифметическое чисел в каждой строке;

// int[,] arr = CreateTwoDimensioalnArr(5, 6, -40, 40);
// PrintArr2(arr);

// int[] SumOfDigitsInStr(int[,] array)
// {
//     int[] res = new int[array.GetLength(0)];
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j= 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i,j];
//         }
//         res[i] = sum;
//         sum = 0;
//     }
//     return res;
// }
// int[] sumInStr = SumOfDigitsInStr(arr);
// int[] meanInStr = sumInStr.Select(x => x / arr.GetLength(1)).ToArray();
// Console.WriteLine("-----------sum digits in string-----------");
// PrintArr(sumInStr);
// Console.WriteLine("-----------mean digits in string-----------");
// PrintArr(meanInStr);

// 3. Формируется и выводится прямоугольный массив (n строк и m столбцов)
// целых случайных чисел от -50 до 50. Вычисляется и выводится: а) среднее
// арифметическое отрицательных чисел в каждой строке; в) сумма и среднее
// арифметическое положительных четных чисел в каждой строке; д) сумма и
// среднее арифметическое всех чисел.

// int nStr = CheckNumberInt("Введите число строк    ");
// int mCol = CheckNumberInt("Введите число столб    ");
// int[,] arr = CreateTwoDimensioalnArr(nStr, mCol, -50, 50);
// PrintArr2(arr);

// double[] meanNegativeInStr = new double[arr.GetLength(0)];

// double[] meanPositiveInStr = new double[arr.GetLength(0)];
// double[] totalSumPositiveInStr = new double[arr.GetLength(0)];

// int sumAllNumbers = 0;
// double meanAllNumbers = 0.0;

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     double sumPositiveStr = 0.0;
//     int countPositiveStr = 0;
//     double sumNegatibeStr = 0.0;
//     int countNegativeStr = 0;
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {   
//         if (arr[i,j] >= 0 && arr[i,j] % 2 ==0 ) {sumPositiveStr += arr[i,j]; countPositiveStr++;}
//         else if (arr[i,j] < 0) {sumNegatibeStr += arr[i,j]; countNegativeStr++;}
//         sumAllNumbers += arr[i,j];
//     }
//     meanPositiveInStr[i] = Math.Round(Convert.ToDouble(sumPositiveStr) / Convert.ToDouble(countPositiveStr),2);
//     meanNegativeInStr[i] = Math.Round(Convert.ToDouble(sumNegatibeStr) / Convert.ToDouble(countNegativeStr),2);
//     totalSumPositiveInStr[i] = sumPositiveStr;
// }

// Console.Write("а)среднее арифметическое отрицательных чисел в каждой строке ");
// PrintArr(meanNegativeInStr);
// Console.Write("в) сумма положительных четных чисел в каждой строке ");
// PrintArr(totalSumPositiveInStr);
// Console.Write("среднее арифметическое положительных четных чисел в каждой строке  ");
// PrintArr(meanPositiveInStr);
// Console.WriteLine($"сумма всех элементов {sumAllNumbers}");
// Console.WriteLine($"среднее арифметичесекое всех чисел {sumAllNumbers / (arr.GetLength(0) * arr.GetLength(1))}");

//4 Формируется и выводится прямоугольный массив - таблица умножения двух
//чисел от 1 до 10.
// int[,] MultiplicationTable()
// {
//     int[,] arr = new int[10,10];
//     for (int i = 1; i < 11; i++)
//     {
//         for (int j = 1; j < 11; j++)
//         {
//             arr[i-1,j-1] = i*j;
//         }
//     }
//     return arr;
// }
// PrintArr2(MultiplicationTable());

// 5. Формируется и выводится прямоугольный массив (6 строк и 8 столбцов)
// целых случайных чисел от -70 до 70. Вычисляется и выводится:
// а) максимальный элемент в каждой строке; б) минимальный положительный
// элемент в каждой строке.

// int[,] arr = CreateTwoDimensioalnArr(6,8,-70,70);
// PrintArr2(arr);
// int[] maxElementInStr = new int[arr.GetLength(0)];
// int[] minPositiveElementInStr = new int[arr.GetLength(0)];

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     int minPos = 100;
//     int maxEl = -100;
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         if (arr[i,j] > maxEl) {maxEl = arr[i,j];}
//         if (arr[i,j] > 0 && arr[i,j] < minPos) {minPos = arr[i,j];}
//     }
//     maxElementInStr[i] = maxEl;
//     minPositiveElementInStr[i] = minPos;
// }

// Console.Write("а) максимальный элемент в каждой строке     ");
// PrintArr(maxElementInStr);

// Console.Write("б) минимальный положительный элемент в каждой строке       ");
// PrintArr(minPositiveElementInStr);


// 6. Формируется и выводится прямоугольный массив (n строк и m столбцов)
// целых случайных чисел от -90 до 90. Вычисляется и выводится:
// а) минимальный из всех отрицательных элементов; б) максимальный из
// модулей всех элементов массива.

// int row = CheckNumberInt("Введите число строк     ");
// int columns = CheckNumberInt("Введите число столбцов     ");

// int[,] arr = CreateTwoDimensioalnArr(row, columns, -90, 90);
// PrintArr2(arr);
// int min = 0;
// int maxModule = 0;

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         if (arr[i,j] < 0 && arr[i,j] < min) {min = arr[i,j];}
//         if (Math.Abs(arr[i,j]) > maxModule) {maxModule = Math.Abs(arr[i,j]);}
//     }
// }

// Console.WriteLine($"а) минимальный из всех отрицательных элементов    {min}");
// Console.WriteLine($"б) максимальный из модулей всех элементов массива    {maxModule}");


// 7. * Формируется и выводится прямоугольный массив (n строк и m столбцов)
// целых случайных чисел от -80 до 80. а) в каждой строке находится
// минимальный элемент и заменяется нулем; б) в каждом столбце находится
// максимальный элемент и заменяется единицей
// int row = CheckNumberInt("число строк    ");
// int columns = CheckNumberInt("число столбцов     ");

// int[,] arr = CreateTwoDimensioalnArr(row, columns, -80, 80);
// PrintArr2(arr);

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     int iMinElement = 0;
//     int jMinElement = 0;
//     int minElement = 81;

//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         if (arr[i,j] < minElement)
//         {
//             minElement = arr[i,j];
//             iMinElement = i;
//             jMinElement = j;
//         }
//     }
//     arr[iMinElement,jMinElement] = 0;
// }

// Console.WriteLine("--------min in str = 0--------");
// PrintArr2(arr);

// for (int i = 0; i < arr.GetLength(1); i++)
// {
//     int iMax = 0;
//     int jMax = 0;
//     int maxElementColumn = -80;

//     for (int j = 0; j < arr.GetLength(0); j++)
//     {
//         if (arr[j,i] > maxElementColumn)
//         {
//             iMax = j;
//             jMax = i;
//             maxElementColumn = arr[j,i];
//         }
//     }
//     arr[iMax,jMax] = 1;
// }
// Console.WriteLine("--------max in column = 1--------");
// PrintArr2(arr);




// 8. Формируется массив и выводится треугольная таблица, заполненная:
// а) единицами; б) нулями.

// string[,] arr = new string[10,10];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         if (i >= j) {arr[i,j] = "1";}
//     }
// }

// Console.WriteLine("------------a)------------");
// PrintArr2(arr);
// Console.WriteLine("------------б)------------");

// string[,] arr2 = new string[10,10];
// for (int i = 0; i < arr2.GetLength(0); i++)
// {
//     for (int j = 0; j < arr2.GetLength(1); j++)
//     {
//         if ((i <= j && i <= (arr2.GetLength(0) - 1 - j)) || (i >= j && i <= (arr2.GetLength(0) - 1 - j))) {arr2[i,j] = "0";}
//     }
// }
// PrintArr2(arr2);