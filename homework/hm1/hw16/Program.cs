// вводим номер дня недели - выводим строку 
//int dayNumber;
string [] arrDays = new string[] {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};

while(true)
{
    Console.Write("Введите цифру дня недели от 1 до 7: ");
    string text = Console.ReadLine();
    if ((int.TryParse(text, out int number)) && (Convert.ToInt32(text)>0 && Convert.ToInt32(text)<8))
    {
        switch(number)
        {
            case 1: Console.WriteLine(arrDays[0]);
            break;
            case 2: Console.WriteLine(arrDays[1]);
            break;
            case 3: Console.WriteLine(arrDays[2]);
            break;
            case 4: Console.WriteLine(arrDays[3]);
            break;
            case 5: Console.WriteLine(arrDays[4]);
            break;
            case 6: Console.WriteLine(arrDays[5]);
            break;
            case 7: Console.WriteLine(arrDays[6]);
            break;
        }
        break;

    }
    else
    {
        Console.WriteLine("Введенное число не удалось распознать");
    }
}