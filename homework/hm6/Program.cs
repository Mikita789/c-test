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

int x1 = CheckNumberInt("Введите число 1   ");
int x2 = CheckNumberInt("Введите число 2   ");
int x3 = CheckNumberInt("Введите число 3   ");
int x4 = CheckNumberInt("Введите число 4   ");
int x5 = CheckNumberInt("Введите число 5   ");
int x6 = CheckNumberInt("Введите число 6   ");
int x7 = CheckNumberInt("Введите число 7   ");

int[] arr = {x1,x2,x3,x4,x5,x6,x7};
PrintArr(arr);

//способ 1  считаю наиболее преемлимым , т.к. лаконичнее 
int[] filtArr = arr.Where(x1 => x1 > 0).ToArray();
Console.WriteLine($"введено {filtArr.Length} элемент-а/-ов  больше 0");


//способ 2
int CountNumbersGreatZero(int[] array)
{
    int res = 0;
    foreach (int number in array)
    {
        if (number > 0) {res += 1;}
    }
    return res;
}
Console.WriteLine(CountNumbersGreatZero(filtArr));


