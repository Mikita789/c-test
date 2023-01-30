int CheckNumberInt(string message)
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

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int x  = CheckNumberInt("enter    ");
// string DescendingNumbers (int number)
// {
//     if (number == 1) return "1";
//     return $"{number}, " + DescendingNumbers(number-1);
// }

// Console.WriteLine(DescendingNumbers(x));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// int m = CheckNumberInt("Enter M .   ");
// int n = CheckNumberInt("Enter N .   ");


// int SumDigitsInNumber (int m, int n)
// {
//     int sum = 0;
//     if (m == n) return n;
//     return m + SumDigitsInNumber(m+1, n) ;
// }

// Console.WriteLine($"M = {m}; N = {n} -> {SumDigitsInNumber(m,n)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int x1 = CheckNumberInt("Enter x1   ");
// int x2 = CheckNumberInt("Enter x2   ");

// int Akkerman (int n, int m)
// {
//     if (n==0) return m + 1;
//     else if (n != 0 && m == 0) return Akkerman(n - 1, 1);
//     else if (n > 0 && m > 0) return Akkerman(n -1, Akkerman (n, m -1));
//     return Akkerman(n, m);
// }
// Console.WriteLine(Akkerman(x1,x2));
