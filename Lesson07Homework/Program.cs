using System;

namespace Lesson07Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();

            counter.OnCount += handler1.Message;
            counter.OnCount += handler2.Message;

            counter.Count(77);

            Console.ReadKey();
        }
    }
}
