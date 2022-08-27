
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


Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num % 7 ==0 && Num % 23 == 0)
{
    Console.WriteLine($"Число {Num} кратно 7 и 23");
}
else Console.WriteLine($"Число {Num} не кратно 7 и 23");

