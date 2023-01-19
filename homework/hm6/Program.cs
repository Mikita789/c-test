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

void PrintArr<T>(T[] arr)
{
    Console.Write("Cгенерированный массив: ");
    foreach (T i in arr)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// int x1 = CheckNumberInt("Введите число 1   ");
// int x2 = CheckNumberInt("Введите число 2   ");
// int x3 = CheckNumberInt("Введите число 3   ");
// int x4 = CheckNumberInt("Введите число 4   ");
// int x5 = CheckNumberInt("Введите число 5   ");
// int x6 = CheckNumberInt("Введите число 6   ");
// int x7 = CheckNumberInt("Введите число 7   ");

// int[] arr = {x1,x2,x3,x4,x5,x6,x7};
// PrintArr(arr);

// //способ 1  считаю наиболее преемлимым , т.к. лаконичнее 
// int[] filtArr = arr.Where(x1 => x1 > 0).ToArray();
// Console.WriteLine($"введено {filtArr.Length} элемент-а/-ов  больше 0");


// //способ 2
// int CountNumbersGreatZero(int[] array)
// {
//     int res = 0;
//     foreach (int number in array)
//     {
//         if (number > 0) {res += 1;}
//     }
//     return res;
// }
// Console.WriteLine(CountNumbersGreatZero(filtArr));


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[] arr1 = new int[2];
int[] arr2 = new int[2];

arr1[0] = CheckNumberInt("Введите число k1:   ");
arr1[1] = CheckNumberInt("Введите число b1:   ");
arr2[0] = CheckNumberInt("Введите число k2:   ");
arr2[1] = CheckNumberInt("Введите число b2:   ");

double[] IntersectionPoint(int[] arr1, int[] arr2)
{
    double x = (Convert.ToDouble(arr2[1]) - Convert.ToDouble(arr1[1]))/(Convert.ToDouble(arr1[0]) - Convert.ToDouble(arr2[0]));
    double y = Convert.ToDouble(arr1[0]) * x + Convert.ToDouble(arr1[1]);
    return new double[] {x,y};
}
double[] result = IntersectionPoint(arr1, arr2);
Console.WriteLine($"Coordinates:  ({result[0]}, {result[1]})");

