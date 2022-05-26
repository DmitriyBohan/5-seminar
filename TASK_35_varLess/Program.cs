/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/


Console.WriteLine("Укажите максимальную цифру массива: ");
int MaxNumberArray = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0, MaxNumberArray + 1);
    }
}

int SumElementNumber(int[] col)
{
    int Count = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] > 9 && col[i] < 100)
        {
            Count++;
        }
    }
    return Count;
}

void PrintArray(int[] array1)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i]);
        if (array1[i] != array1.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("] -> ");
}


int[] array = new int[5];

FillArray(array);
int result = SumElementNumber(array);
PrintArray(array);


Console.Write(result);
