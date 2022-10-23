// Задайте двумерный массив, наполненный случайными вещественными числами

int GetUserNumber(string message, string errorMess)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMess);
    }
}

double[,] RandomArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
        }
    }

    return array;

}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int rows = GetUserNumber("Input rows quantity: ", "Error input! Try again: ");
int columns = GetUserNumber("Input columns quantity: ", "Error input! Try again: ");
double[,] array = RandomArray(rows, columns);
PrintArray(array);
