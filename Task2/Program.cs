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
// Поиск числа в массиве
Console.Write("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());

if (rows < table.GetLength(0) && colums < table.GetLength(1))
    Console.WriteLine(table[rows, colums]);

else Console.WriteLine($"{rows} {colums} -> такой позиции в массиве нет");