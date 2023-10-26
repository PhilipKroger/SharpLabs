// Агрегация вложением

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        class A
        {
            public A() { c.c1 = 5; }
            ~A() { }

            public class B
            {
                public B() { }
                ~B() { }

                public class D
                {
                    public D() { }
                    ~D() { }
                    public void mD() { Console.WriteLine(" method of D"); }
                }
                
                public class K
                {
                    public K() { }
                    ~K() { }
                    public void mK() { Console.WriteLine(" method of K"); }
                }

                public void mB() { Console.WriteLine(" method of B"); }
                public K kA { get { Console.Write("get k -> "); return k; } }
                public D dA { get { Console.Write("get d -> "); return d; } }
                private K k = new K();
                private D d = new D();
            }

            public class C
            {
                public C() { this.c1 = 10; }
                ~C() { }

                public class E
                {
                    public E() { }
                    ~E() { }
                    public void mE() { Console.WriteLine(" method of E"); }
                }

                public class F
                {
                    public F() { }
                    ~F() { }
                    public void mF() { Console.WriteLine(" method of F"); }
                }
                
                public void mC() { Console.WriteLine(" method of C"); }

                public E eA { get { Console.Write("get e -> "); return e; } }
                public F fA { get { Console.Write("get f -> "); return f; } }
                private E e = new E();
                private F f = new F();
                
                public int c1 { set; get; }
            }

            public class J
            {
                public J() { }
                ~J() { }

                public void mJ() { Console.WriteLine(" method of J"); }
            }

            public void mA() { Console.WriteLine(" method of A"); }

            public B bA { get { Console.Write("get b ->"); return b; } }
            public C cA { get { Console.Write("get c ->"); return c; } }
            public J jA { get { Console.Write("get j ->"); return j; } }

            private B b = new B();
            private C c = new C();
            private J j = new J();

        }

        static void Main(string[] args)
        {
            A a = new A();

            a.mA();

            a.bA.mB();
            a.cA.mC();
            a.jA.mJ();

            a.bA.dA.mD();

            a.cA.eA.mE();
            a.cA.fA.mF();
            a.cA.eA.mE();

            Console.ReadKey();
        }
    }
}

