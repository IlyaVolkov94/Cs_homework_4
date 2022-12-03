// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
//Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.

Console.WriteLine("Массив:");
int Size = 8;
if (CheckEqual(RandomArray(Size))) Console.WriteLine("TRUE");
else Console.WriteLine("False");


int[] RandomArray(int Arg)  //Создает произвольно заполненный массив
{
    int[] Array = new int[Arg];
    for (int i = 0; i < Arg; i++)
    {
        Array[i] = new Random().Next(0, 2);
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine("");
    return Array;
}


bool CheckEqual(int[] Array)    //Если в массиве единиц больше чем нулей возвращает булево значение true, иначе возвращает false
{
    int CountOne = 0;
    int CountZero = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] == 1) CountOne++;
        else CountZero++;
    }
    if (CountOne > CountZero)
        return true;
    else
        return false;
}