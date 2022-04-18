// Дана монотонная последовательность, в которой каждое натуральное число n встречается ровно n раз: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... 
//Дано число m. Выведите первые m членов этой последовательности.
//m = 5 >> 1, 2, 2, 3, 3

Console.WriteLine("Введите число M");
int countM = Convert.ToInt32(Console.ReadLine());

Sequence(countM);

void Sequence(int count, int number = 0, int countnum = 0)
{
    //for (int i = 1; i < count; i++)
    if (count == 0)
    {
        return;
    }
    for (int i = 0; countnum < count; i++)
    {
        countnum = countnum + i;
        number = i;
    }
    Sequence(--count);
    Console.Write(number + " , ");
}
