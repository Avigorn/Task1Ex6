// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
int ReadInt(string message)
{
    System.Console.Write($"{message}: ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int[,] GenerateArray(int rows, int cols)
{
    int[,] arrayD2 = new int[rows, cols];
    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayD2.GetLength(1); j++)
        {
            arrayD2[i, j] = new Random().Next(0, 100);
        }
    }
    return arrayD2;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}



int rows = ReadInt("Введите количество строк");
int columns = ReadInt("Введите количество столбцов");
int[,] arr = GenerateArray(rows, columns);
ShowArray(arr);

int positionX = ReadInt("Введите номер строки");
int positionY = ReadInt("Введите номер стобца");
if (positionX < arr.GetLength(0) && positionY < arr.GetLength(1))
{
    System.Console.WriteLine(arr.GetValue(positionX -1, positionY -1));
}
else System.Console.WriteLine($"Такого числа в массиве нет");