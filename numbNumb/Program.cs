// Квадрат числа 
//Console.WriteLine("Введите число для возведения в квадрат  ");
//int number = Convert.ToInt32(Console.ReadLine());
//Console.Write("Квадрат введенного числа равен   ");
//Console.WriteLine("Квадрат числа " + number + " будет равен " + number * number);

while (true)
{
    Console.Write("Введите число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        Console.Write("Введенное число в квадрате = ");
        Console.WriteLine(number*number);
        break;
    }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}
