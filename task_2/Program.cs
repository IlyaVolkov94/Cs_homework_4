// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.

int SumDigit(int Num)
{
    int NumBuf = 0;
    if (Num > 0)
    {
        while (Num >= 1)
        {
            NumBuf += Num % 10;
            Num /= 10;
        }
    }
    else    //В случае если число отрицательно, то посчитал все разряды положительными, кроме крайнего левого. Получается крайнее левое будет вычитаться из суммы последующих разрядов.
    {
        Num = -Num;
        while (Num >= 10)
        {
            NumBuf += Num % 10;
            Num /= 10;
        }
    }
    NumBuf += -(Num % 10);
    return NumBuf;
}

Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
int Sum = SumDigit(Number);
Console.WriteLine("Сумма разрядов числа равна: " + Sum);