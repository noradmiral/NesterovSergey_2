// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число {number}");

int FindNewDigit(int num)
{
    int first = number / 100;
    int third = number % 10;
    return first * 10 + third;
}

int result = FindNewDigit(number);

Console.WriteLine($"Искомое число: {result}");