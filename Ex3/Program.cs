// Дано натуральное число n > 1. Вывести все простые множители данного числа.
//10 >> 5, 2.
//12 >> 2, 2, 3.

Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 1) Console.WriteLine("Введите корректное число");

Del(number);

void Del(int num, int del = 1)
{
    if (num == 1)
    {
        return;
    }
    del++; 
    if (num % del == 0)
    {
        Console.WriteLine(del);
        num /= del;
        del = 1;
    } 
    Del(num, del);
}
