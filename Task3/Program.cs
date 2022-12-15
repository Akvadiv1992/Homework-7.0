//Заполнение массива рандом числами от 1 до 9
void RandomArray(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i, j] = new Random().Next(1, 10); // [1,9]
        Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
// Создание массива и вывод в терминал
int[,] table = new int[4,4];
RandomArray(table);

Console.WriteLine();

// Среднее арифметическое каждого столбца
for (int j = 0; j < table.GetLength(1); j++)
{
    double sum = 0;
        for (int i = 0; i < table.GetLength(0); i++)
        {
        sum += table[i, j];
        }
Console.Write($"{ sum / table.GetLength(0)} \t");
}