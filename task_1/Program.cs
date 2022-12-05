//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double NaturalPow(double Base, int Pow)
{
    double Res = 1;
    for (int i = 0; i < Pow; i++)
    {
        Res *= Base;
    }
    return Res;
}

Console.WriteLine("Введите основание для возведения в степень");
double Base = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите степень");
int Pow = Convert.ToInt32(Console.ReadLine());
double Result = NaturalPow(Base, Pow);
Console.WriteLine($"{Base} в степени {Pow} равен: {Result}");