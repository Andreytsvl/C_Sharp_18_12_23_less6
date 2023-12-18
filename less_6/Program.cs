class Program
{
    static void Main()
    {
        // Создаем двумерный массив символов
        char[,] array = new char[,]
        {
            { 'H', 'e', 'l', 'l', 'o' },
            { 'W', 'o', 'r', 'l', 'd' }
        };

        // Создаем строку из символов массива
        string str = "";

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                str += array[i, j];
            }
        }

        // Выводим строку на экран
        Console.WriteLine(str);
    }
}
