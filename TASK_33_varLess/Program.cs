/*
Задача 33: Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

Console.WriteLine("Напиши из скольки цифр ты хочешь получить массив: ");
int SizeArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите интервал массива: ");
int FindNumberArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Какую цифру будем искать в массиве? ");
int MaxNumberArray = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(-MaxNumberArray, MaxNumberArray+1);
    }
}

void PrintArray(int[] col)
{
    Console.Write("[");
    for (int position = 0; position < col.Length; position++)
    {
        Console.Write(col[position]);
        if (position != col.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

bool DetectNumber(int[] array)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (FindNumberArray == array[i])
        {
            result = true;
            break;
        }
    }
    return result;
}
int[] array1 = new int[SizeArray];
FillArray(array1);
PrintArray(array1);
bool HasNumber = DetectNumber(array1);
Console.Write((HasNumber)?" -> Да":" -> Нет");


