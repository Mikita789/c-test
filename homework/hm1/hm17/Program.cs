//на вход подается число N. на выход целые числа от -N до N

while(true)
{
    Console.Write("Введите целое число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        for(int i = -number; i<=number; i++)
        {
            Console.WriteLine(i);
        }
    }
    else
    {
        Console.WriteLine("Не удалось распознать число");
    }
}
