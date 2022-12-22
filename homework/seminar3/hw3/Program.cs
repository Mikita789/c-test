// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

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
//             if (Math.Abs(number).ToString().Length == 5)
//             {
//                 result = number;
//                 Console.WriteLine($"Вы ввели {result}");
//                 flag = false;
//             }
//             else {Console.WriteLine("Вы ввели не пятизначное число. Попоробуйте снова");}
//         }
//         else {Console.WriteLine("Не удалось определить число. Попробуйте еще раз.");}
//     }
//     return result;
    
// }

// string Palindr5 (int x)
// {
//     string xToStr = Math.Abs(x).ToString();
//     string revStr = new String(xToStr.ToCharArray().Reverse().ToArray());
//     string result = (xToStr.Length >=5) && (revStr == xToStr) ? "Palindrome":"Not a palindrome" ;
//     return result;
// }
// // string m = "thisString";
// // string n = new String(m.ToCharArray().Reverse().ToArray());
// // Console.WriteLine(n);

// int x = CheckNumberInt("enter number: ");
// Console.WriteLine(Palindr5(x));

// Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

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

// double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     double resultDist = double.Round(Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2)),2) ;
//     return resultDist;
// }

// int x1 = CheckNumberInt("Введите коорд x первой точки:  ");
// int y1 = CheckNumberInt("Введите коорд y первой точки:  ");
// int z1 = CheckNumberInt("Введите коорд z первой точки:  ");

// int x2 = CheckNumberInt("Введите коорд x второй точки:  ");
// int y2 = CheckNumberInt("Введите коорд y второй точки:  ");
// int z2 = CheckNumberInt("Введите коорд z второй точки:  ");

// Console.WriteLine($"расстояние между точками = {Distance(x1,y1,z1,x2,y2,z2)}");


// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

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
// int n = CheckNumberInt("Введите число:  ");
// for (int i =1; i<=n; i++)
// {
//     Console.WriteLine($"|| {i} **3 = {Math.Pow(i,3)} ||");
// }