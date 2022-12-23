// Дополнительные задания по теме массив: https://drive.google.com/file/d/1PurYbjxB7zBX5s1oxLmgZq7BRE2DRT5v/view

// 1. Задан массив дней недели. По введенному порядковому номеру
// выводится название дня недели и количество дней до Вс.

// string[] days = {"понедельник","вторник","среда","четверг","пятница","суббота","воскресенье"};
// bool flag = true;
// int numb = 0;
// while (flag)
// {
//     Console.Write("Введите порядковый номер дня недели:  ");
//     string text = Console.ReadLine();
//     if (int.TryParse(text, out int number))
//     {
//         if (number>=1 && number<=7)
//         {
//             Console.WriteLine($"Вы ввели {number}");
//             numb = number;
//             flag = false;
//         }
//         else {Console.WriteLine("Введенное число не в диапазоне 1...7. Попробуйте снова");}
//     }
//     else {Console.WriteLine("Не удалось распознать число. Попробуйте снова");}
// }

// Console.WriteLine($"Это {days[numb-1]}. До наступления воскресенья осталось {7-numb-1} дня.");


// 2. Заданы диагонали мониторов в дюймах: 10.1, 11.6, 14, 15.6, 17, 19, 24, 27.
// Формируется и выводится таблица перевода диагоналей в сантиметры.

// double[] diArr = {10.1, 11.6, 14, 15.6, 17, 19, 24, 27};
// foreach (double n in diArr)
// {
//     Console.WriteLine($"|| {n} || {n*2.54} cm ||");
// }

// 3. Формируется массив из 7 целых двузначных чисел путем ввода с клавиатуры.
// Выводится этот массив, четные числа и их количество.

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
//             if (Math.Abs(result).ToString().Length == 2)
//             {
//                 Console.WriteLine($"Вы ввели {result}");
//                 flag = false;
//             }
//             else {Console.WriteLine($"Число не является двухзначным. Попробуйте снова.");}
//         }
//         else {Console.WriteLine($"Не удалось распознать число. Попробуйте снова.");}
//     }
//     return result;
// }
// int[] arrNumbers = new int[7];

// for (int i = 0; i<=6; i++)
// {
//     arrNumbers[i] = CheckNumberInt("Введите двухзначное число:  ");
// }
// Console.Write("Получившейся массив:   ");
// foreach (int i in arrNumbers)
// {
//     Console.Write($"{i}  ");
// }
// Console.WriteLine();
// int[] filterArr = arrNumbers.Where(x => x%2==0).ToArray();
// Console.WriteLine($"Есть {filterArr.Length} четных чисел");
// foreach (int n in filterArr)
// {
//     Console.Write($"{n}  ");
// }


// 4. Формируется массив из n натуральных нечетных чисел.
// Выводится исходный массив и числа кратные 3. ( for, foreach )

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
        else {Console.WriteLine($"Не удалось распознать число. Попробуйте снова.");}
    }
    return result;
}
// int n = CheckNumberInt("Введите количество элементов массива  ");
// bool flag = true;
// int[] arrNumbers = new int[n];

// int count = 0;
// while (flag)
// {
//     int x = new Random().Next(-1000,1000);
//     if (x%2!=0) 
//     {
//         arrNumbers[count] = x;
//         count++;
//     }
//     if (count == n ) {flag = false;}
// }
// Console.Write("Исходный массив случайных чисел:  ");
// foreach (int i in arrNumbers)
// {
//     Console.Write($"{i}  ");
// }

// Console.WriteLine();

// int[] filterArr = arrNumbers.Where(x=> x%3 == 0).ToArray();
// Console.Write("Отсортированный массив:   ");
// foreach (int i in filterArr)
// {
//     Console.Write($"{i}  ");
// }

void PrintElementArr(int[] x)
{
    foreach (int i in x)
    {
        Console.Write($"{i}  ");
    }
}

int[] RandomNumbersArrCreate(int n, int a, int b) 
{
    int[] resultArr = new int[n];
    bool flag = true;
    for (int i = 0; i<=n-1; i++)
    {
        resultArr[i] = new Random().Next(a,b);
    }
    return resultArr;
}

// 5. Формируется массив из n целых случайных чисел от 10 до 99
// Выводится исходный массив, нечетные числа и их количество. ( for, foreach )

// int x = CheckNumberInt("Введите количество необходимых элементов   ");
// bool flag = true;
// int[] numbersArr = new int[x];

// for (int i = 0; i<=x-1; i++)
// {
//     numbersArr[i] = new Random().Next(10,99);
// }
// Console.WriteLine("Исходный массив:   ");
// PrintElementArr(numbersArr);
// Console.WriteLine();

// int[] filterArr = numbersArr.Where(x=> x%2!=0).ToArray();
// Console.WriteLine("Отфильтрованный массив:   ");
// PrintElementArr(filterArr);
// Console.WriteLine();
// Console.WriteLine($"Количество элементов итогового массива:   {filterArr.Length}");


// 6. Формируется массив из n целых случайных чисел от -50 до 50.
// Массив упорядочивается. Выводятся числа в интервале от – 20 до +20.

// int n = CheckNumberInt("Введите необходимое количество элементов   ");

// int[] numbersArr = RandomNumbersArrCreate(n,-50,50);
// int [] filterArr = numbersArr.Where(x=> x>=-20 && x<=20).ToArray();
// Array.Sort(filterArr);
// Console.Write("Отфильтрованный массив:   ");
// PrintElementArr(filterArr);


// 7. Формируется массив из n целых случайных чисел от -40 до 40.
// Выводятся нечетные отрицательные числа и их к-во. ( for, foreach )

// int n = CheckNumberInt("Введите необходимое количество элементов  ");
// int[] numbersArr = RandomNumbersArrCreate(n,-40,40);
// int[] filterArr = numbersArr.Where(x=> x%2!=0 && x<0).ToArray();
// Console.Write("Отфильтрованный массив:  ");
// PrintElementArr(filterArr);
// Console.WriteLine();
// Console.WriteLine($"количество элементов:  {filterArr.Length}");

// 8. Формируется массив из n целых случайных чисел от -50 до 50.
// Выводятся положительные числа в порядке убывания и их количество.

// int n = CheckNumberInt("Введите необходимое количество элементов  ");
// int[] numbersArr = RandomNumbersArrCreate(n,-50,50);
// int[] filterArr = numbersArr.Where(x=> x>0).ToArray();
// Array.Sort(filterArr);

// Console.Write("Отфильтрованный массив:  ");
// PrintElementArr(filterArr.Reverse().ToArray());
// Console.WriteLine();
// Console.WriteLine($"количество элементов:  {filterArr.Length}");


// 9. Заданы массивы названий и обозначений транспортных средств, а также
// их скоростей, например: a – автомобиль, 70 км/ч; v – велосипед, 12 км/ч;
// m - мотоцикл, 60 км/ч; p – поезд, 90 км/ч; s – самолет, 800 км/ч)
// По введенному обозначению транспортного средства
// выводится его название и скорость.

// string[] x = {"a","v","m","p","s"};
// string[] name = {"автомобиля","велосипеда","мотоцикла","поезда","самолета"};
// int[] speed = {70, 12, 60, 90, 800};
// bool flag = true;

// while (flag)
// {
//     Console.Write("Введите обозначение транспортного средства (a, v, m, p, s)  ");
//     string text = Console.ReadLine();
//     if (x.Contains(text.ToLower())) 
//     {
//         int index = Array.IndexOf(x, text);
//         Console.WriteLine($"скорость {name[index]} = {speed[index]}");
//         flag = false;
//     }
//     else {Console.WriteLine("Не удалось распознать транспортное средство. Повторите попытку и введите обозначение транспортного средства (a, v, m, p, s)");}
// }


// 10. * По введенному порядковому номеру месяца и дате выводится:
// название месяца, количество дней в нем, количество дней, оставшихся
// до конца текущего месяца, название следующего месяца.

// int mon = CheckNumberInt("Введите порядковый номер месяца  ");
// string[] monName = {"январь","февраль","март","апрель","май","июнь","июль","август","сентябрь","октябрь","ноябрь","декабрь"};
// int[] dayInMon = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
// int day = CheckNumberInt("Введите дату   ");
// if (monName[mon-1] == null)
// {
//     Console.WriteLine("Номер месяца должен быть из диапазона 1...12");
//     mon = CheckNumberInt("Введите порядковый номер месяца  ");
// }
// else if (day>dayInMon[mon-1] && day<1)
// {
//     Console.WriteLine("Недопустимое значение дней для выбранного месяца. Попробуйте снова.");
//     day = CheckNumberInt("Введите дату   ");
// }
// else
// {
//     Console.WriteLine($"Это {monName[mon-1]}\nколичество дней в нем: {dayInMon[mon-1]}\nдо конца месяца осталось {dayInMon[mon-1] - day} дней\nследующий месяц {(mon == 12 ? monName[0] : monName[mon])}");
// }




