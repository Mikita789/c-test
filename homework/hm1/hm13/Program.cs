// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

while (true)
{
    Console.Write("Введите число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        Console.Write("Вы ввели чиcло 1: ");
        if(number%2 == 0)
        {
            Console.WriteLine($"Число {number} является четным");
        }
        else
        {
            Console.WriteLine($"Число {number} является нечетным");
        }
        break;
    }
    Console.WriteLine("Не удалось распознать число 1, попробуйте еще раз.");
}