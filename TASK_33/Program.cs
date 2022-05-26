/*
Задача 33: Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

Console.WriteLine("Напиши из скольки цифр ты хочешь получить массив: ");
int SizeArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите максимальную цифру массива: ");
int MaxNumberArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Какую цифру хотите найти в случайном массиве?");
int FindNumber = Convert.ToInt32(Console.ReadLine());

int[] array = new int[SizeArray];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, MaxNumberArray + 1);
    if (array[i] == FindNumber)
    {
        count++;
    }

}
Console.Write("В массиве [");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i < array.Length - 1)
    {
        Console.Write(",");
    }
}
Console.Write("] -> ");
if (count > 0)
{
    Console.WriteLine("Есть цифра " + FindNumber);
}
else
{
    Console.WriteLine("Нет цифры " + FindNumber);
}
