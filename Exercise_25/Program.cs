// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// double pow = Math.Pow(3,5);

Console.WriteLine("Программа для для возведения первого числа в степннь второго числа");
Console.WriteLine("Введите числa: ");

int num1 = Convert.ToInt32(Console.ReadLine());
{
    if (num1 < 1)
        num1 = Math.Abs(num1);
}

int num2 = Convert.ToInt32(Console.ReadLine());
{
    if (num2 < 1)
        num2 = Math.Abs(num2);
}
void res()
{
    Console.WriteLine("Результат: " + Math.Pow(num1, num2));
}
res();

// Console.WriteLine("Программа для для возведения первого числа в степннь второго числа");
// Console.WriteLine("Введите числa: ");

// void res()
// {
//     double num1 = Convert.ToInt32(Console.ReadLine());
//     int num2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Результат: " + Math.Pow(num1, num2));
// }
// res();

// Console.WriteLine("Программа для для возведения первого числа в степннь второго числа");
// Console.WriteLine("Введите числa: ");
// double num1 = Convert.ToInt32(Console.ReadLine());
// double num2 = Convert.ToInt32(Console.ReadLine());
// double result = Math.Pow(num1,num2);
// Console.WriteLine ($"число {num1} в степени {num2} равно {result}");
