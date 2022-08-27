
// ------- Семинар 2. Задача 1 --------------------------
// int randomNumber = new Random().Next(10,100);

// int firsDigit = randomNumber/10;
// int secondDigit = randomNumber%10;

// int maximum = firsDigit;
// if (secondDigit > maximum) maximum = secondDigit;

// Console.WriteLine ($"Максимальная цифра в числе {randomNumber} равняется {maximum}");



// -------- Семинар 2. Задача 2 ---------------------------
// string number;
// number = Convert.ToString(new Random().Next(100,1000));

// Console.WriteLine ($"Число {number} преобразовано в {number [0]}{number[2]}");


// -------- Семинар 2. Задача 3 ---------------------------

// Console.WriteLine("Введите первое число");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int secondNum = Convert.ToInt32(Console.ReadLine());

// if (firstNum % secondNum == 0)
// {
//     Console.WriteLine($"Число {firstNum} кратно {secondNum}");
// }
// else
// {
//     Console.WriteLine($"остаток от деления числа {firstNum} на число {secondNum} равен {firstNum % secondNum}");
// }

// -------- Семинар 2. Задача 4 ---------------------------


// Console.WriteLine("Введите число");
// int Num = Convert.ToInt32(Console.ReadLine());

// if (Num % 7 ==0 && Num % 23 == 0)
// {
//     Console.WriteLine($"Число {Num} кратно 7 и 23");
// }
// else Console.WriteLine($"Число {Num} не кратно 7 и 23");

// // ---------- Семинар 2. Домашнее задание -------------------------
// Задача 10 нужно решить через ЦЕЛЫЕ ЧИСЛА, без строчек
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// ------ Решение:

// Console.WriteLine("Введите целое трехзначное число:");
// int Num = Convert.ToInt32(Console.ReadLine());

// int result = (Num % 100) / 10;
// Console.WriteLine($"Введите число {Num} имеет вторую цифру {result}");


// // ---------- Семинар 2. Домашнее задание -------------------------
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// ------ Решение:

// Console.WriteLine("Введите любое целое число:");
// string Num = Convert.ToString(Console.ReadLine());

// int lenghtNum = Num.Length;

// if (lenghtNum >= 3) Console.WriteLine($"Третья цифра введенного числа {Num} - > {Num[2]}");
// else Console.WriteLine($"Введенное число {Num} не имеет третьей цифры");



// // ---------- Семинар 2. Домашнее задание -------------------------
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// ------ Решение:

Console.WriteLine("Введите номер дня недели от 1 до 7:");

int weekNum = Convert.ToInt32(Console.ReadLine());

if (weekNum >= 1 && weekNum <= 5) Console.WriteLine($"День недели не выходной");

if (weekNum == 6 || weekNum == 7) Console.WriteLine($"День недели выходной");