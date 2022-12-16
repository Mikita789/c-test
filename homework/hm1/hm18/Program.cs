// на вход трехзначное число. вывести последнюю цифру числа

while(true)
{
    Console.Write("Введите 3х значное число: ");
    string text = Console.ReadLine();
    if(int.TryParse(text, out int number))
    {
        Console.Write("Последняя цифра введенного числа = ");
        Console.WriteLine(number.ToString()[^1]);
        break;

    }
    else
    {
        Console.WriteLine("Правильно введите 3х значное число");
    }
}
