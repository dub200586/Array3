using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = new List<string>() {"Mercedes ", "BMW ", "Opel ", "Wolkswagen ", "Porsche "};

            cars.AddRange(new[] { "Citroen ", "Peugeot " });

            foreach (var car in cars)
                Console.Write(car);
            Console.WriteLine();

            cars.RemoveAt(3);

            foreach (var car in cars)
                Console.Write(car);
            Console.WriteLine();

            cars.Remove("Citroen");

            foreach (var car in cars)
                Console.Write(car);
            Console.WriteLine();

            cars.Sort();

            foreach (var car in cars)
                Console.Write(car);

            ArrayList myGirl = new ArrayList() {"Vika ", "Katia ", "Anna ", "Sveta ", "Tania "};

            myGirl.AddRange(new string[] { "NoName1 ", "NoName2 " });

            foreach (object name in myGirl)
                Console.Write(name);
            Console.WriteLine();

            myGirl.RemoveAt(3);

            foreach (object name in myGirl)
                Console.Write(name);
            Console.WriteLine();

            myGirl.Remove("NoName1 ");

            foreach (object name in myGirl)
                Console.Write(name);
            Console.WriteLine();

            myGirl.Sort();

            foreach (object name in myGirl)
                Console.Write(name);

            Console.ReadKey();
        }
    }
}
