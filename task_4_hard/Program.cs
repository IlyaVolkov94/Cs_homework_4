﻿// See https://aka.ms/new-console-template for more information

try
{
Console.WriteLine("Введите число");
double Number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Количество цифр в числе: "+CheckSumIndex(Number));
}
catch
{
    Console.WriteLine("Ошибка выполнения");
}

//Функция подсчета количества цифр в числе
int CheckSumIndex(double Num)
{
double NumFract = Num;
int CountMod=0;
if(Num<0) Num=-Num;
if(Num<1)
{
    CountMod++;
    goto Fract;
}
while(Num>=1)
{
    Num/=10;
    CountMod++;
}
Fract:
int CountFract = -1;
while(NumFract%10!=0)
{
    NumFract*=10;
    CountFract++;
}
return CountMod+CountFract;
}