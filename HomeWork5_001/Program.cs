// Задача 1: Задайте массив заполненный случайными положительными трёхзначными
//  числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateArray(int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(100, 1000);
    }
    return tempArray;
}

void PrintArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

int Sum(int[] array)
{
    int find = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            find += 1;
        }
    }
    return find;
}

int len = 12;
int[] array = CreateArray(len);
PrintArray(array);

System.Console.WriteLine();
System.Console.WriteLine($"Кличество четных чисел = {Sum(array)}");
