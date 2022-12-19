// задача 10

int numb = 0;
bool flag = true;

while(flag)
{
    Console.Write("Введите 3х значное число: ");
    string text = Console.ReadLine();
    if(int.TryParse(text, out int number))
    {
        numb = number;
        flag = false;
        Console.WriteLine($"Вторая цифра числа : {numb.ToString()[1]}");
    }
    else
    {
        Console.WriteLine("Введите 3х значное число!!!");
    }
    
}