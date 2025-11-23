using Tyuiu.SvaykinVE.Sprint5.Task0.V12.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Свайкин В. Е. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Обработка файлов                                                  *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнил: Свайкин Владислав Евгеньевич | АСОиУб-25-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Дано выражение вычислить его значение при x = 3,                        *");
        Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask0.txt                *");
        Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*  y = x^3/2(x+5)^2                                                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        int x = 3;
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"X = {x}");
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Файл: {res}\nСоздан!");
        Console.ReadKey();
    }
}