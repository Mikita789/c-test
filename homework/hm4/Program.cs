//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


//функция ввода цифры и ее проверки
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

// int a = CheckNumberInt("Введите число 1 ");
// int b = CheckNumberInt("Введите число 2 ");

// int Exp (int x1, int x2)
// {
//     int result = x1;
//     for (int i=1; i < x2; i++)
//     {
//         result *= x1;
//     }
//     return result;
// }
// Console.Write($"Число А({a}) в степени числа B({b}): ");
// Console.WriteLine(Exp(a,b));


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int a = CheckNumberInt("Введите число ");
// //способ 1
// int SumOfDigits(int x)
// {
//     int result = 0;
//     string xs = x.ToString();
//     for (int i = 0; i < xs.Length; i++)
//     {
//         result += int.Parse(xs[i].ToString());
//     }
//     return result;
// }

// //Console.WriteLine($"Cумма цифр числа({a}) равна {SumOfDigits(a)}");
// // способ 2 OneLine
// int SumOfDigits2(int x)
// {
//     return Array.ConvertAll(x.ToString().ToCharArray(),s => int.Parse(s.ToString())).Sum();
// }
// Console.WriteLine(SumOfDigits2(a));


