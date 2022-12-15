// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int number1;
int number2;
int number3;
string maxNumber;


Console.WriteLine("Сейчас мы проверим какое число больше");

//первое число
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
//Второе число
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
// Третье число
while (true)
{
    Console.Write("Введите число 3: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        Console.Write("Вы ввели чсило 3: ");
        number3 = number;
        Console.WriteLine(number);
        break;
    }
    Console.WriteLine("Не удалось распознать число 3, попробуйте еще раз.");
}

if(number1>number2 && number1>number3)
{
    Console.Write("Число 1 максимальное  ");
    Console.WriteLine(number1);
}
if(number2>number1 && number2>number3)
{
    Console.WriteLine("Число 2 максимальное ");
    Console.WriteLine(number2);
}
if(number3>number1 && number3>number2)
{
    Console.WriteLine("Число 3 максимальное ");
    Console.WriteLine(number3);
}