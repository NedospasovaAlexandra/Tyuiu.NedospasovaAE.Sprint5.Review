using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.NedospasovaAE.Sprint5.TaskReview.V24.Lib;

namespace Tyuiu.NedospasovaAE.Sprint5.TaskReview.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Недоспасова.А.Э | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Решение спринта                                                   *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнила: Недоспасова Александра Эдуардовна | ИИПб-23-2                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V5.txt (файл взять из         *");
            Console.WriteLine("* архива согласно вашему варианту. Создать папку в ручную                 *");
            Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл), в котором есть набор         *");
            Console.WriteLine("* символьных данных. Заменить все русские слова на 'слово' сохранить      *");
            Console.WriteLine("* в файл OutPutDataFileTask7V24.txt                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";
            string path = @"C:\Users\ASUS\source\repos\Tyuiu.NedospasovaAE.Sprint5.Review\Tyuiu.NedospasovaAE.Sprint5.TaskReview.V24\bin\Debug\InPutDataFileTask7V24.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine("Заменить все русские слова на 'слово'. Результат находится в папке, расположенной на пути: " + pathSaveFile);
            Console.ReadKey();
        }
    }
}
