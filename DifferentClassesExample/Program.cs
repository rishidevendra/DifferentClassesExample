using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            main obj = new main();
            int data = obj.getA();
            Console.WriteLine(data);
            main.aInternal obj1 = new main.aInternal();  // Internal means accessible only in that assembly. If you try to create object in other assembly it will throw error
            int data1 = obj1.getB();
            Console.WriteLine(data1);
            A.A1();
            A.A2();
            A obj3 = new A();
            obj3.B1();
            Console.ReadKey();
        }
    }

    class main
    {
        int a = 2;
        public main()
        {
            a = 4;
        }
        public int getA()
        {
            return a;
        }
        internal class aInternal {
            int b = 2;
            public aInternal()
            {
                b = 5;
            }
            public int getB()
            {
                return b;
            }
        }
    }
    class derived : main
    {
        public int c = 4;
        public derived()
        {
            aInternal obj = new aInternal();
        }
    }

    partial class A
    {
        public static void A1()
        {
            Console.WriteLine("Function A1");
        }
    }
    partial class A
    {
        public void B1()
        {
            Console.WriteLine("Function B1");
        }       
        public static void A2()
        {
            Console.WriteLine("Function A2");
        }
    }
}
