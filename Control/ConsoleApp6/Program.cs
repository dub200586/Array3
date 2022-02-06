using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass person1 = new NextClass("ddd", "fff", 23);
            BaseClass person2 = new SecondClass("ddd", "eeef", 23);
            person1.BaseMethod();
            person2.BaseMethod();

            Console.ReadKey();
        }
    }
    class BaseClass
    {
        string name;
        string surname;

        public BaseClass() { }
        public BaseClass(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public virtual void BaseMethod()
        {
            Console.Write(name + " " + surname);
        }
    }

    class NextClass : BaseClass
    {
        int old;

        public NextClass(string name, string surname, int old)
            : base(name, surname)
        {
            this.old = old;
        }
        public override void BaseMethod()
        {
            base.BaseMethod();
            Console.WriteLine(" " + old);
        }
    }

    class SecondClass : BaseClass
    {
        int experience;

        public SecondClass(string name, string surname, int experience)
            : base(name, surname)
        {
            this.experience = experience;
        }
        public override void BaseMethod()
        {
            base.BaseMethod();
            Console.WriteLine(" " + experience);
        }
    }
}
