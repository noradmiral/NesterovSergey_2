// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите 2 целых числа");
int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());

void IsSquare (int num1, int num2)
{
    if(num1 * num1 == num2 || num2 * num2 == num1) Console.WriteLine($"{num1}, {num2} -> да");
    else Console.WriteLine($"{num1}, {num2} -> нет");
}

IsSquare(firstNum, secondNum);