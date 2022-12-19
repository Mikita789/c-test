// практический семина 2 
// 11 трехзначное число. вывести первую и посл цифру

// int randInt = new Random().Next(100,999);
// Console.WriteLine($"число = {randInt}");
// Console.WriteLine($"{randInt.ToString()[0]}{randInt.ToString()[2]}");

//12 
// bool flag = true;
// int numb1 = 0;
// int numb2 = 0;

// while(flag)
// {
//     Console.Write("Введите число 1 : ");
//     string text = Console.ReadLine();
//     if(int.TryParse(text, out int number))
//     {
//         Console.WriteLine($"Вы ввели число 1 = {number}");
//         numb1 = number;
//         flag = false;
//     }
//     else
//     {
//         Console.WriteLine("Число введено не верно");
//     }
// }
// flag = true;

// while(flag)
// {
//     Console.Write("Введите число 2 : ");
//     string text = Console.ReadLine();
//     if(int.TryParse(text, out int number))
//     {
//         Console.WriteLine($"Вы ввели число 2 = {number}");
//         numb2 = number;
//         flag = false;
//     }
//     else
//     {
//         Console.WriteLine("Число введено не верно");
//     }
// }
// if(numb1%numb2 == 0)
// {
//     Console.WriteLine("Первое число кратно второму");
// }
// else
// {
//     Console.WriteLine($"Первое число не  кратно второму и остаток от деления равен {numb1%numb2}");
// }



// № 14 
// int numbers =0;
// bool flag = true;

// while(flag)
// {
//     Console.Write("Введите число : ");
//     string text = Console.ReadLine();
//     if(int.TryParse(text, out int number))
//     {
//         Console.WriteLine($"Вы ввели число 2 = {number}");
//         numbers = number;
//         flag = false;
//     }
//     else
//     {
//         Console.WriteLine("Число введено не верно");
//     }
// }
// if(numbers%7 == 0 && numbers % 23 == 0)
// {
//     Console.WriteLine("Yes");

// }
// else
// {
//     Console.WriteLine("NO");
// }

//№16
// int numb1 = 0;
// int numb2 = 0;
// bool flag = true;
// while(flag)
// {
//     Console.Write("Введите число 1 : ");
//     string text = Console.ReadLine();
//     if(int.TryParse(text, out int number))
//     {
//         numb1 = number;
//         flag = false;
//     }
//     else
//     {
//         Console.WriteLine("Неверный формат введенного числа");
//     }

// }

// flag = true;
// while(flag)
// {
//     Console.Write("Введите число 2 : ");
//     string text = Console.ReadLine();
//     if(int.TryParse(text, out int number))
//     {
//         numb2 = number;
//         flag = false;
//     }
//     else
//     {
//         Console.WriteLine("Неверный формат введенного числа");
//     }

// }

// if(numb1*numb1 == numb2)
// {
//     Console.WriteLine($"Число 1 ({numb1}) в квадрвте является вторым числом ({numb2}) ");
// }
// else
// {
//     Console.WriteLine($"Число 1 ({numb1} в квадрвте не является вторым числом {numb2} )");
// }