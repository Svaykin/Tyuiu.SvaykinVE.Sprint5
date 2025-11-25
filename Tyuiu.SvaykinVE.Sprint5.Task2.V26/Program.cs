using Tyuiu.SvaykinVE.Sprint5.Task2.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mtrx = new int[3, 3] { { 2, -3, -3 },
                                         {-8, 8, 0 },
                                         { -6, 1, 0 }};
        int rows = mtrx.GetUpperBound(0) + 1;
        int columns = mtrx.Length / rows;
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Свайкин В. Е. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема:                                                                   *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Свайкин Владислав Евгеньевич | АСОиУб-25-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(mtrx);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}