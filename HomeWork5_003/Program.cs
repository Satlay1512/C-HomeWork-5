// Задача 3: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateArray(int length)

{
    int[] tempArray = new int[length];

    for (int i = 0; i < length; i++)

    {
        tempArray[i] = new Random().Next(0, 10);
    }

    return tempArray;
}

void printArray(int[] intArray)

{

    System.Console.Write($"{intArray[0]}");

    for (int i = 1; i < intArray.Length; i++)

    {

        System.Console.Write($", {intArray[i]} ");

    }

}

int FindMax (int [] intArray)

{
    int max = intArray[0];

    for (int i = 1; i < intArray.Length; i++)
    {
        if (intArray[i] > max)
        {
            max = intArray[i];
        }
    }
    return max;
}
int FindMin (int [] intArray)

{
    int min = intArray[0];

    for (int i = 1; i < intArray.Length; i++)
    {
        if (intArray[i] < min)
        {
            min = intArray[i];
        }
    }
    return min;
}

void Run()
{
    int length = 8;
    int[] randomArray = CreateArray(length);
    printArray(randomArray);
    int Max = FindMax(randomArray);
    int Min = FindMin(randomArray);
    int Diff = Max - Min;
    System.Console.WriteLine();
    Console.WriteLine($" Разница между максимальным числом {Max}, и минимальным числом {Min}  равна {Diff}");
}
Run();