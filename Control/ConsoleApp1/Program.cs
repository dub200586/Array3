using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString name = new MyString("fgh", "dfgh");
            Console.WriteLine(name.ReversString());
        }
    }

    class MyString
    {
        private string rts1;
        private string rts;

        public string Str1 { get; }
        public string Str { get; }
        public MyString(string str) => this.Str = str;

        public MyString(string str, string str1) : this(str)
        {
            this.Str1 = str1;
        }

        public string ReversString()
        {
            if (Str1 != null)
            {
                char[] str1tarray = Str1.ToCharArray();
                Array.Reverse(str1tarray);
                rts1 = new string(str1tarray);
            }

            if (Str != null)
            {
                char[] strtarray = Str.ToCharArray();
                Array.Reverse(strtarray);
                rts = new string(strtarray);
            }

            return rts1 + rts;
        }
    }
}
