// Напишите программу, которая на вход принимает позицию элемента в двумерном массиве и
// возвращает число или же указание, что такого элемента нет

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

void FindUserNumber (int [,] array, int userNumberRow, int userNumberColumn)
{
    if (userNumberRow < array.GetLength(0) && userNumberColumn < array.GetLength(1))
        Console.WriteLine($"Element value -> {array[userNumberRow, userNumberColumn]}");
    else Console.WriteLine($"This element is not present");
}



Console.Clear();
int rows = GetNumberFromUser("Input quantity rows: ", "Error input! Try again.");
int columns = GetNumberFromUser("Input quantity columns: ", "Error input! Try again.");
int minValue = GetNumberFromUser("Input minValue: ", "Error input! Try again.");
int maxValue = GetNumberFromUser("Input maxValue: ", "Error input! Try again.");
int [,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
int userNumberRow = GetNumberFromUser("Input find row: ", "Error input! Try again.");
int userNumberColumn = GetNumberFromUser("Input find column: ", "Error input! Try again.");
FindUserNumber(array, userNumberRow, userNumberColumn);