// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int number1;

while (true)
{
    Console.Write("Введите число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        Console.Write("Вы ввели чиcло: ");
        Console.WriteLine(number);
        number1 = number;
        break;
    }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}



// for (int i = 1; i <= number1; i++)
// {
//     if(i%2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }

if(number1%2==0)
{
    for(int i = 0; i<=number1; i+=2)
    {
        Console.WriteLine(i);
    }
}
else
{
    for(int i = 0; i<number1; i+=2)
    {
        Console.WriteLine(i);
    }
}