using System;

namespace CS.Itself.GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            

            A aa = new A();
            aa = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            B b = new B(new A());
            b = null;
        }
    }

    class A
    {
        ~A()
        {
            Console.WriteLine("Destructing A class instance");
        }
    }

    class B
    {
        private object Ref;

        public B(object o)
        {
            Ref = o;
        }

        ~B()
        {
            Console.WriteLine("Destucting B class instance");
        }
    }
}
