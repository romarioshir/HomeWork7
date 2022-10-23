// Задайте двумерный массив из целых чисел.
// Найдите среднее арифмитическое элементов в каждом столбце

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
        return result;
    }
}

void PrintArray(int[,] array)
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

void ArithmeticMean(int[,] array)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double count = 0;
        double arith = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            count++;
        }
        arith = sum / count;
        Console.WriteLine($"Среднее арифметическое столбца = {arith}");
    }

}

Console.Clear();
int rows, columns;
while (true)
{
    rows = GetNumberFromUser("Input quantity rows: ", "Error input! Try again.");
    if (rows > 0)
        break;
    else Console.Write("Error input! Try again. ");
}
while (true)
{
    columns = GetNumberFromUser("Input quantity columns: ", "Error input! Try again.");
    if (columns > 0)
        break;
    else Console.Write("Error input! Try again. ");
}

int minValue = GetNumberFromUser("Input minValue: ", "Error input! Try again.");
int maxValue = GetNumberFromUser("Input maxValue: ", "Error input! Try again.");
int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
ArithmeticMean(array);