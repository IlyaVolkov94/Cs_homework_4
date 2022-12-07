// Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.


int[] InputArray(int Size)  //Функция ввода массива
{
    int[] Array = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return Array;
}

void PrintArray(int[] Array) //Функция для печати массива
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
    Console.WriteLine("");
}

try
{
    int Size = 8;
    int[] Array = new int[Size];
    Array = InputArray(Size);
    PrintArray(Array);
}

catch
{
    Console.WriteLine("Ошибка выполнения");
}