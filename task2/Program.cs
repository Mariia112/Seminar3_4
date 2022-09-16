// 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

//достаем цифры из числа в обратном порядке
Console.Write("Введите число: ");
int numbers = int.Parse(Console.ReadLine()!);
int sum = 0;

while (numbers > 0)
{
    int digit = numbers % 10;
    sum += digit;
    numbers = numbers / 10;
}

Console.WriteLine($"Сумма цифр в числе - {sum}");
