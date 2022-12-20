﻿//дополнительные задачи из файла lab11_algo.pdf


//  1. Генерируется случайное целое число n в интервале [ 20 – 99 ].
// Проверяется, делится ли оно на введенное с клавиатуры целое число d
// (используйте тернарный оператор).

// int numb = new Random().Next(20,99);
// int numb2 = 0;
// bool flag = true;

// while (flag)
// {
//     Console.Write("Введите число: ");
//     string text = Console.ReadLine();
//     if (int.TryParse(text , out int number))
//     {
//         numb2 = number;
//         string res = "";
//         res = (numb % numb2 == 0) ? $"Рандомное число({numb}) делистся нацело на введенное({numb2})" : $"Рандомное число({numb}) НЕ делистся нацело на введенное({numb2})";
//         Console.WriteLine(res);
//         flag = false;
//     }
//     else
//     {
//         Console.WriteLine("Не удалось распознать число. Попробуйте снова");
//     }
//}




// 2. Генерируются два случайных целых числа a и b в интервале [10 – 30].
// Если a > b, выводится их разность, eсли a < b, выводится сумма,
// eсли a == b, выводится сообщение “числа равны”. (оператор if)

// int numb1 = new Random().Next(10,30);
// int numb2 = new Random().Next(10,30);
// if (numb1 > numb2) {Console.WriteLine($"Число 1({numb1}) больше числа 2({numb2}). Разность = {numb1 - numb2}");}
// else if (numb2 > numb1) {Console.WriteLine($"Число 2({numb2}) больше числа 1({numb1}). Сумма = {numb1 + numb2}");}
// else {Console.WriteLine($"Числа 1({numb1}) и 2({numb2}) равны");}


// 3. Генерируются два случайных целых числа c и d в интервале [-10 – 10].
// Если оба числа четные, выводится их частное, если оба нечетные - их сумма,
// если одно число четное, а другое нечетное, выводится их произведение ( if )

// int c = new Random().Next(-10,10);
// int d = new Random().Next(-10,10);

// if (c % 2 == 0 && d % 2 == 0) {Console.WriteLine($"Оба числа({c} и {d}) четные. Частное = {Convert.ToDouble(c/d)}");}
// else if (c % 2 != 0 && d % 2 !=0) {Console.WriteLine($"Оба числа({c} и {d}) нечетные. Cумма = {c+d}");}
// else {Console.WriteLine($"Одно число четное, второе - нет. C{c} и D{d}. Произведение = {c*d}");}




// 4. По введенному номеру месяца выводится название поры года (зима, весна,
// лето, осень) и сообщение: сессия, каникулы, 1 семестр, 2 семестр ( if ).
// 1 семестр - сент - конец нояб
// сессия 1 - декабрь
// каникулы 1 - январь
// 2 семестр - февр - конец апр
// 2 сессия май - июнь 
// каникулы 2 июль - сент


// bool flag = true;

// while (flag)
// {
//     Console.Write("Введите число месяца: ");
//     string text = Console.ReadLine();
//     if (int.TryParse(text, out int number))
//     {
//         string mes1 = "";
//         string mes2 = "";
//         if ((number>0 && number<3) || number == 12) {mes1 = "зима\n";
//                                    if (number == 1) {mes2 = "каникулы";}
//                                    if (number == 2) {mes2 = "2 семестр";} 
//                                    if (number == 12) {mes2 = "1 сессия";};}

//         else if ((number>2 && number<6) || number == 12) {mes1 = "весна\n";
//                                                           if (number == 3 || number == 4) {mes2 = "второй семестр";}
//                                                           if (number == 5) {mes2 = "вторая сессия";};}
//         else if (number>5 && number<9) {mes1 = "лето\n";
//                                         if (number == 6) {mes2 = "вторая сессия";}
//                                         if (number == 7 || number == 8) {mes2 = "вторые каникулы";};}
//         else if (number>8 && number<12) {mes1 = "осень\n";
//                                          if (number>=9 || number<=11) {mes2 = "первый семестр";};}
//         Console.WriteLine(mes1 + " " + mes2);
//         flag = false;
//     }
//     else
//     {
//         Console.WriteLine("Введенное число не опознано.");
//     }
// }



// 5. Проверяется соответствие веса и роста (ввод рост и вес; вывод одного
// из сообщений "Норма", "Нужно похудеть", "Нужно поправиться".
// Нормальный вес (в кг) = (рост (в см) – 100) ± 10%. (оператор if )

// double m = 0;
// double h = 0;
// bool flag = true;

// while (flag)
// {
//     Console.Write("Введите ваш вес: ");
//     string text = Console.ReadLine();
//     if (double.TryParse(text, out double number))
//     {
//         m = number;
//         flag = false;
//     }
//     else
//     {
//         Console.Write("Не удалось распознать число. Попробуйте снова");
//     }
// }

// flag = true;

// while (flag)
// {
//     Console.Write("Введите ваш рост (в СМ): ");
//     string text = Console.ReadLine();
//     if (double.TryParse(text, out double number))
//     {
//         h = number;
//         flag = false;
//     }
//     else
//     {
//         Console.Write("Не удалось распознать число. Попробуйте снова");
//     }
// }

// if (m >= (h-100)-(h-100)*0.1 && m <= (h-100)+(h-100)*0.1)
// {
//     Console.WriteLine("Вес в норме");
// }
// else if (m < (h-100)-(h-100)*0.1)
// {
//     Console.WriteLine("Недовес");
// }
// else if (m > (h-100)+(h-100)*0.1)
// {
//     Console.WriteLine("Недовес");
// }

// 6. Введенная цифра (от 0 до 5) выводится прописью (оператор switch).


// bool flag = true;
// string[] arr = {"ноль", "один", "два", "три", "четыре", "пять"};

// while (flag)
// {
//     Console.Write("Введите цифру от 0 до 5: ");
//     string text = Console.ReadLine();
//     if (int.TryParse(text, out int number))
//     {
//         if (number>=0 && number<=5)
//         {
//             switch (number)
//             {
//                 case 0: Console.WriteLine(arr[0]); break;
//                 case 1: Console.WriteLine(arr[1]); break;
//                 case 2: Console.WriteLine(arr[2]); break;
//                 case 3: Console.WriteLine(arr[3]); break;
//                 case 4: Console.WriteLine(arr[4]); break;
//                 case 5: Console.WriteLine(arr[5]); break;
//                 default: Console.WriteLine("нет данных"); break;
//             }
//             flag = false;
//         }
//         else
//         {
//             Console.WriteLine("Ввели не в диапазоне 0...5. Повторите");
//         }
//     }
// }


// 7. Выводится название предмета по введенной первой букве: ф - физика, м -
// математика, и - история, г - география, б - биология (оператор switch).

// string s = "";
// Console.WriteLine("Введите название предмета");
// s = Console.ReadLine();

// switch (s[0])
// {
//     case ('ф') : Console.WriteLine("Физика"); break;
//     case ('м') : Console.WriteLine("Математика"); break;
//     case ('и') : Console.WriteLine("История"); break;
//     case ('г') : Console.WriteLine("География"); break;
//     case ('б') : Console.WriteLine("Биология"); break;
//     default: Console.WriteLine("Нет данных"); break;
// }

// 8. Выводится название страны и ее столицы по введенной первой букве:
// б – Беларусь, Минск, р – Россия, Москва, л –Литва, Вильнюс (switch)
// string s = "";
// Console.WriteLine("Введите первую букву страны");
// s = Console.ReadLine();

// switch (s[0])
// {
//     case ('б') : Console.WriteLine("Беларусь, Минск"); break;
//     case ('р') : Console.WriteLine("Россия, Москва"); break;
//     case ('л') : Console.WriteLine("Литва, Вильнюс"); break;
//     default: Console.WriteLine("Нет данных"); break;
// }

// 9. По введенному номеру выводится название дня недели (1 – пн, 2 –вт,...)
// и сообщение “рабочий день” или “выходной” (операторы switch, if).

// string[] arrDay = {"пн", "вт", "ср", "чт", "пт", "сб", "вс"};
// string jb = "рабочий день!";
// string fr = "выходной день!";
// bool flag = true;
// while (flag)
// {
//     Console.Write("Введите номер дня недели");
//     string text = Console.ReadLine();
//     if (int.TryParse(text, out int number))
//     {
//         if (number>0 && number<8)
//         {
//             switch (number)
//             {
//                 case 1 : Console.WriteLine($"{arrDay[number-1]} и это {jb}"); break;
//                 case 2 : Console.WriteLine($"{arrDay[number-1]} и это {jb}"); break;
//                 case 3 : Console.WriteLine($"{arrDay[number-1]} и это {jb}"); break;
//                 case 4 : Console.WriteLine($"{arrDay[number-1]} и это {jb}"); break;
//                 case 5 : Console.WriteLine($"{arrDay[number-1]} и это {jb}"); break;
//                 case 6 : Console.WriteLine($"{arrDay[number-1]} и это {fr}"); break;
//                 case 7 : Console.WriteLine($"{arrDay[number-1]} и это {fr}"); break;
//             }
//             flag = false;
//         }
//         else
//         {
//             Console.WriteLine("Неверный диапазон числа. введите значение от 1 до 7");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Не удалось определить число. Попробуйте снова");
//     }
// }



// 10. Проверяется правильность введенного логина строго из 5 букв
// и пароля из 6 и более цифр.
// Console.Write("Введите логин:  ");
// string login = Console.ReadLine();
// Console.Write("Введите пароль:  ");
// string password = Console.ReadLine();
// bool globalFlag = true;
// if (login.Length == 5)
// {
//     bool flag = true;
//     for (int i = 0; i<login.Length; i++)
//     {
//         if (int.TryParse(login[i].ToString(), out int number))
//         {
//             Console.WriteLine("Логин должен содержать только буквенные символы");
//             flag = false;
//             globalFlag = false;
//             break;
//         }
//         if (flag == false) {break;}
//     }
//     if (flag == true) {Console.WriteLine($"Логин успешно принят:  {login}");}
// }
// else
// {
//     Console.WriteLine("Логин должен состоять из 5 символов");
//     globalFlag = false;
// }



// // проверка пароля
// if (globalFlag == true)
// {
//     if (password.Length >= 6)
//     {
//     if (!int.TryParse(password, out int passwordNumbers))
//         {
//         Console.WriteLine("Пароль должен состоять только из цифр");
        
//         }
//         else 
//         {
//         Console.WriteLine($"Пароль успешно принят:  {new string('*', password.Length)}");
//         }

//     }
//     else
//     {
//     Console.WriteLine("Пароль должен состоять из 6 и более цифрр.");
//     }
// }



