/*
Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените 
на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

Console.WriteLine("Напиши из скольки цифр ты хочешь получить массив: ");
int SizeArray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите интервал массива: ");
int MaxNumberArray = Convert.ToInt32(Console.ReadLine());

int[] array = new int[SizeArray];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(MaxNumberArray*-1, MaxNumberArray+1);
}

Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i < array.Length - 1)
    {
        Console.Write(",");
    }
}
Console.Write("] -> ");

for (int i = 0; i < array.Length; i++)
{

    array[i] = array[i] * -1;

}

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
