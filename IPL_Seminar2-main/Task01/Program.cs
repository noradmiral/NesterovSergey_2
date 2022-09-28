// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
int number = new Random().Next(10, 100);
// int firstDigit = number / 10;
// int secondDigit = number % 10;

// 1. решение с помощью обычного ветвления
// if(firstDigit == secondDigit) Console.WriteLine($"Обе цифры числа {number} равны");
// else if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {number} -> {secondDigit}"); 

//2. то же ветвление с использованием переменной для результата
// int maxDigit = 0;
// if (firstDigit > secondDigit) maxDigit = firstDigit;
// else maxDigit = secondDigit;

//3. При помощи тернарного оператора
//int maximDigit = firstDigit > secondDigit ? firstDigit : secondDigit; // если fDigit больше чем sDigit, то в maxDigit присваиваем fDigit, инача в maxDigit присваиваем sDigit

int MaxDigit(int num)
{
    int fDigit = num / 10;
    int sDigit = num % 10;
    if(IsEqualDigit(fDigit, sDigit)) return -1;
    return fDigit > sDigit ? fDigit : sDigit;
}


bool IsEqualDigit(int num1, int num2)
{
    return num1 == num2;
}

int maxDigit = MaxDigit(number);
string result = maxDigit != -1 ? maxDigit.ToString() : "Цифры равны";
Console.WriteLine($"Наибольшая цифра числа {number} => {result}");