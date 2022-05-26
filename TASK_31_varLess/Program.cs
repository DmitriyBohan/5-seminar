/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными 
числами из промежутка [-9, 9]. Найдите сумму отрицательных и 
положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
чисел равна 29, сумма отрицательных равна -20.
*/

int[] GetNumber(int length, int deviation)
{
    int[] result = new int[length];
    for (var i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
    }
    return result;
}
void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
// multiply 1 for counting positiv -1 for negative
int SumElementsOfArray(int[] arrayToCalculate, int multuply)
{
    int result = 0;
    for (int i = 0; i < arrayToCalculate.Length; i++)
    {
        if (arrayToCalculate[i] * multuply > 0)

        {
            result += arrayToCalculate[i];
        }
    }
    return result;
}

int[] randomArray = GetNumber(12, 9);
int positiveSumOfArray = SumElementsOfArray(randomArray,1);
int negativeSumOfArray = SumElementsOfArray(randomArray,-1);
PrintArray(randomArray);
Console.WriteLine($"Cумма положительных элементов {positiveSumOfArray}, сумма отрицательных {negativeSumOfArray}");
