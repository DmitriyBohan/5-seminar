/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными 
числами из промежутка [-9, 9]. Найдите сумму отрицательных и 
положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
чисел равна 29, сумма отрицательных равна -20.
*/
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}
int SumMinNumber = 0;
int SumMaxNumber = 0;
void SumNumber(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            SumMaxNumber = SumMaxNumber + array[i];
        }
        else
        {
            SumMinNumber = SumMinNumber + array[i];
        }
    }
}
int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
}

Console.Write("В массиве ");
PrintArray(array);
SumNumber(array);
Console.WriteLine(" ");
Console.WriteLine($"Cумма положительных чисел равна: {SumMaxNumber}");
Console.WriteLine($"Сумма отрицательных равна: {SumMinNumber}");
