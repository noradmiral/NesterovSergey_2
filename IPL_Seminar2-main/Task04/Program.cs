// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число кратность которого будет проверена");
int numCheck = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите число на кратность которому будет проврено число {numCheck}");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите число на кратность которому будет проврено число {numCheck}");
int secondNum = Convert.ToInt32(Console.ReadLine());

void IsMultiple(int check, int num1, int num2)
{
    if(check % num1 == 0 && check % num2 == 0) 
    {
        Console.WriteLine($"Число {check} кратно обоим числам {num1} и {num2}");
    }
    else 
    {
        Console.WriteLine($"Число {check} не кратно одному из чисел {num1} и {num2}, или не кратно обоим этим числам");
    }
}
IsMultiple(numCheck, firstNum, secondNum);
