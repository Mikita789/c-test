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


// в виде функций

// int CheckNumberInt (string message)
// {
//     bool flag = true;
//     int result = 0;
//     while (flag)
//     {
//         Console.Write(message);
//         string text = Console.ReadLine();
//         if (int.TryParse(text, out int number))
//         {
//             result = number;
//             Console.WriteLine($"Вы ввели {result}");
//             flag = false;
//         }
//         else {Console.WriteLine("Не удалось определить число. Попробуйте еще раз.");}
//     }
//     return result;
    
// }

// int x = CheckNumberInt("Введите число 1:  ");
// int y = CheckNumberInt("Введите число 2:  ");

// string CheckCoord (int x, int y)
// {
//     switch (x,y)
//     {
//     case (>0, >0): return "Первая четверть"; break;
//     case (<0, >0): return "Вторая четверть"; break;
//     case (<0, <0): return "Третья четверть"; break;
//     case (>0, <0): return "Четвертая четверть"; break;
//     default: return "Not info" ; break;
//     }

// }

// Console.WriteLine(CheckCoord(x,y));

//по номеру четверти определить диапазоны значений 
// Console.WriteLine("Введите название четвети, диапазон которой хотите выяснить");
// string text = Console.ReadLine();
// switch (text.ToLower())
// {
//     case ("первая"): Console.WriteLine("x > 0 and y>0"); break;
//     case ("вторая"): Console.WriteLine("x < 0 and y>0"); break;
//     case ("третья"): Console.WriteLine("x < 0 and y<0"); break;
//     case ("четвертая"): Console.WriteLine("x > 0 and y<0"); break;
//     default: Console.WriteLine("нет данных") ;break;
// }


//расстояние между точками 
// int CheckNumberInt (string message)
// {
//     bool flag = true;
//     int result = 0;
//     while (flag)
//     {
//         Console.Write(message);
//         string text = Console.ReadLine();
//         if (int.TryParse(text, out int number))
//         {
//             result = number;
//             Console.WriteLine($"Вы ввели {result}");
//             flag = false;
//         }
//         else {Console.WriteLine("Не удалось определить число. Попробуйте еще раз.");}
//     }
//     return result;
    
// }
// int x1 = CheckNumberInt("Enter x1 coord:  ");
// int y1 = CheckNumberInt("Enter y1 coord:  ");
// int x2 = CheckNumberInt("Enter x2 coord:  ");
// int y2 = CheckNumberInt("Enter y2 coord:  ");

// double Xy (int x1, int y1, int x2, int y2)
// {
//     double result = Math.Sqrt(Convert.ToDouble(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)));
//     return double.Round(result,2);
// }

// Console.WriteLine($"расстояние между точками = {Xy(x1,y1,x2,y2)}");