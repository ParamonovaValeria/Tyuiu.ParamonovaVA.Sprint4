using Tyuiu.ParamonovaVA.Sprint4.Task0.V21.Lib;

namespace Tyuiu.ParamonovaVA.Sprint4.Task0.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Парамонова В.А. | РППб-24-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #4                                                            *");
            Console.WriteLine("* Тема:                                                                *");
            Console.WriteLine("* Задание #0                                                           *");
            Console.WriteLine("* Вариант #21                                                          *");
            Console.WriteLine("* Выполнил: Парамонова Валерия Алексеевна  | РППб-24-1                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");
            int[] numArray = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };

            Console.WriteLine("Заданный массив: " + "[{0}]", string.Join(",", numArray));
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма чётных элементов массива - " + ds.GetSumEvenArrEl(numArray));
            Console.ReadKey();
        }
    }
}
