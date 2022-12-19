// 15 задача
int numb = 0;
bool flag = true;

while (flag)
{
    Console.Write("Введите число от 1 до 7: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        numb = number;
        if (numb==6 || numb==7)
        {
            Console.WriteLine("Да");
            flag = false;
        }
        else if (numb > 0 && numb<=5)
        {
            Console.WriteLine("Нет");
            flag = false;
        }
        else
        {
            Console.WriteLine("Введено число не из диапазона 1...7");
        }
        
    }
    else
    {
        Console.WriteLine("Вы ввели не цифру");
    }
}
