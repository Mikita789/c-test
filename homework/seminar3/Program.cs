// дано x and y. Вывести четверть

// int x = 0;
// int y = 0;
// bool flag = true;

// while (flag)
// {
//     Console.Write("Введите точку х:  ");
//     string text = Console.ReadLine();
//     if (text == "0") {Console.WriteLine("Введите больше 0");}
//     else if (int.TryParse(text, out int number))
//     {
        
//         x = number;
//         Console.WriteLine($"вы ввели {x}");
//         flag = false;
//     }
//     else
//     {
//         Console.WriteLine("Не удалось распознать число");
//     }
// }
// flag = true;

// while (flag)
// {
//     Console.Write("Введите точку y:  ");
//     string text = Console.ReadLine();
//     if (text == "0") {Console.WriteLine("Введите больше 0");}
//     else if (int.TryParse(text, out int number))
//     {
        
//         y = number;
//         Console.WriteLine($"вы ввели {y}");
//         flag = false;
//     }
//     else
//     {
//         Console.WriteLine("Не удалось распознать число");
//     }
// }

// switch (x,y)
// {
//     case (>0, >0): {Console.WriteLine("Первая четверть"); break;}
//     case (<0, >0): {Console.WriteLine("Вторая четверть"); break;}
//     case (<0, <0): {Console.WriteLine("Третья четверть"); break;}
//     case (>0, <0): {Console.WriteLine("Четвертая четверть"); break;}
//     default: break;
// }


// в виде функции

int CheckNumberInt (string message)
{
    bool flag = true;
    int result = 0;
    while (flag)
    {
        Console.Write(message);
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            result = number;
            Console.WriteLine($"Вы ввели {result}");
            flag = false;
        }
        else {Console.WriteLine("Не удалось определить число. Попробуйте еще раз.");}
    }
    return result;
    
}

int x = CheckNumberInt("Введите число 1:");
int y = CheckNumberInt("Введите число 2:");

string CheckCoord (int x, int y)
{
    switch (x,y)
    {
    case (>0, >0): return "Первая четверть"; break;
    case (<0, >0): return "Вторая четверть"; break;
    case (<0, <0): return "Третья четверть"; break;
    case (>0, <0): return "Четвертая четверть"; break;
    default: return "Not info" ; break;
    }

}

Console.WriteLine(CheckCoord(x,y));