//  Дано число n. Получите число, записанное в обратном порядке.
//345 >> 543
//81 >> 18

Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

Revers(number);

void Revers(int num, int newnumber = 0)
{
    newnumber = newnumber*10 + num%10;
    num /=10;
    if (num > 0) 
    {
    
        Revers(num, newnumber);
        
    }
    if (num == 0) Console.WriteLine(newnumber);
}
