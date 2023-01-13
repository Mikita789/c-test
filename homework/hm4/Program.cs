//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

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

int a = CheckNumberInt("Введите число 1 ");
int b = CheckNumberInt("Введите число 2 ");

int Exp (int x1, int x2)
{
    int result = x1;
    for (int i=1; i < x2; i++)
    {
        result *= x1;
    }
    return result;
}
Console.Write($"Число А({a}) в степени числа B({b}): ");
Console.WriteLine(Exp(a,b));
