// 13 задача 
int numb = 0;
bool flag = true;

while (flag)
{
    Console.Write("Введите 3х значное число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        numb = number;
        Console.WriteLine($"Вы ввели чсло = {numb}");
        if (number.ToString().Length == 3)
        {
            Console.WriteLine($"Третья цифра введенного числа: {numb.ToString()[^1]}");
            flag = false;
        }
        else
        {
            Console.WriteLine("Введенное число не содержит 3х чисел");
            
        }
        
    }
    else
    {
        Console.WriteLine("Вы ввели не число, попробуйте снова");
    }

}