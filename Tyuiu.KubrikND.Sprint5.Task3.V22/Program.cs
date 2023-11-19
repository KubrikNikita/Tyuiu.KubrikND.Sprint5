using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KubrikND.Sprint5.Task3.V22.Lib;
using System.IO;

namespace Tyuiu.KubrikND.Sprint5.Task3.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Кубрик Н.Д. | ИСПб-23-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Класс File. Запись данных в текстовый файл                                   *");
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #22                                                                  *");
            Console.WriteLine("* Выполнил: Кубрик Никита Дмитриевич | ИСПб-23-1                               *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить         *");
            Console.WriteLine("* в бинарный файл OutPutFileTask3.bin и вывести на консоль.                    *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                      *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* y (x) = (1 - x, 2) / (-3 * x)                                                *");
            Console.WriteLine("x = " + x);

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            double res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
