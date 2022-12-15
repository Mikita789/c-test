// принимаем два числа и проверяем не является ли первое число квадратом второго
int number1;
int number2;


while (true)
{
    Console.Write("Введите число 1: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        Console.Write("Вы ввели чиcло: ");
        Console.WriteLine(number);
        number1 = number;
        break;
    }
    Console.WriteLine("Не удалось распознать число 1, попробуйте еще раз.");
}

while (true)
{
    Console.Write("Введите число 2: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        Console.Write("Вы ввели чиcло: ");
        Console.WriteLine(number);
        number2 = number;
        break;
    }
    Console.WriteLine("Не удалось распознать число 2, попробуйте еще раз.");
}

if((number1*number1) == number2)
{
    Console.WriteLine($"Квадрат числа 1({number1}) является числом 2({number2})");
}
else
{
    Console.WriteLine($"Квадрат числа 1 {number1} не является числом 2 {number2}");
}

