using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack arr = new MyStack(5);
            arr.Push(234);
            arr.Push(2);
            Console.WriteLine(arr.Pop());
            Console.WriteLine(arr.Pop());
        }
    }
    class MyStack
    {
        int[] array;
        int count;
        int n = 5;
        public MyStack() 
        {
            array = new int[n];
        }
        public MyStack(int length)
        {
            array = new int[length];
        }
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        public int Count
        {
            get { return count; }
        }
        public void Push(int item)
        {
            if (count == array.Length)
                throw new InvalidOperationException("Переполнение стека");
            array[count++] = item;
        }
        public int Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            int item = array[--count];
            array[count] = default(int);
            return item;
        }
    }
}
