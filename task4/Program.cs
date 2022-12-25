void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(10, 100);
        }
    }
}

void maxArray(int[,] array)
{
    Console.WriteLine("после преобразования");
    int maxNumber = array[0, 0];
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if(array[m, n] > maxNumber)
            {
                maxNumber = array[m, n];
            }
        }
    }
}

void TransformArray(int[,] array)
{
    int maxNumber = array[0, 0];
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if(array[m, n] == array[m, n])
            {
                array[m, n] = maxNumber;
                maxNumber++;
            }
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


int[,] arr = new int[7, 7];
FillArray(arr);
PrintArray(arr);
maxArray(arr);
TransformArray(arr);
PrintArray(arr);