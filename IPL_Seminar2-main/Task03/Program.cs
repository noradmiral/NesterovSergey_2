// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите 2 целых числа");
int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());


void FindMultiplicity (int num1, int num2)
{
    if(firstNum % secondNum == 0) Console.WriteLine($"{firstNum} кратно {secondNum}");
    else Console.WriteLine($"{firstNum} не кратно {secondNum} остаток от деления равен {firstNum % secondNum}");
}

FindMultiplicity(firstNum, secondNum);