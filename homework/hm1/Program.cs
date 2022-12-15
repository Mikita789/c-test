// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Console.WriteLine("Hello, World!");

int number1;
int number2;


Console.WriteLine("Сейчас мы проверим какое число больше");
while (true)
{
    Console.Write("Введите число 1: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        Console.Write("Вы ввели чсило 1: ");
        number1 = number;
        Console.WriteLine(number);
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
        Console.Write("Вы ввели чсило 2: ");
        number2 = number;
        Console.WriteLine(number);
        break;
    }
    Console.WriteLine("Не удалось распознать число 2, попробуйте еще раз.");
}

if(number1>number2)
{
    Console.WriteLine("Число 1 больше числа 2");
}
else
{
    Console.WriteLine("Число 2 больше числа 1");
}

