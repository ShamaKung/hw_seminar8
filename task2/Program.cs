void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}

int Sum(int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (m == 0) 
            {
                sum += array[m, n];
                minSum += array[m, n]; 
            }
            else sum += array[m, n]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNum = m;
        }
        sum = 0;
    }
    return minNum;
}

int[,] array = new int[7, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Строка с наименьшей суммой элементов: " + Sum(array));