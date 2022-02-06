using System;
using System.Collections.Generic;

namespace Collection1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CustomList> custom = new List<CustomList>();

            custom.Add(new CustomList("Kolia", 55, true));
            custom.Add(new CustomList("Vasia", 30, false));
            custom.Add(new CustomList("Masha", 18, false));
            custom.Add(new CustomList("Sergey", 24, true));

            AddMethod(new CustomList("Denis", 36, true));

            void AddMethod(CustomList person)
            {
                custom.Add(person);

                custom.Sort();

                for (int i = 0; i < custom.Count; i++)
                {
                    Console.WriteLine("Имя: {0}, Возраст: {1}, Женат/Замужем: {2}", custom[i].Name, custom[i].Old, custom[i].Married);
                }
            }
            Console.ReadKey();
        }
    }

    class CustomList : IComparable<CustomList>
    {
        public string Name { get; }
        public int Old { get; }
        public bool Married { get; }
        public CustomList(string name, int old, bool married)
        {
            this.Name = name;
            this.Old = old;
            this.Married = married;
        }

        public int CompareTo(CustomList item)
        {
            return string.Compare(this.Name, item.Name);
        }
    }
}
