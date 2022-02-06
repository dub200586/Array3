using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.WorldCreation());

            Console.ReadKey();
        }
    }

    public static class DataTimeExtension
    {
        public static string WorldCreation(this DateTime MonthName)
        {
            return string.Format("День {0} месяца {1} года {2} от сотворения мира", DateTime.Now.ToString("dd"), MonthName.ToString("MMMM"), DateTime.Now.AddYears(5501).ToString("yyyy"));
        }
    }
}
